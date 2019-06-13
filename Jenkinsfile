def label = "slave-${UUID.randomUUID().toString()}"
def jenkins_base = env.JENKINS_URL

podTemplate(label: label, containers: [
containerTemplate(name: 'jnlp', image: 'laxmikantk/baseimage:docker', args:'http://137.116.115.143:8080/computer/${computer.name}/slave-agent.jnlp',
  )],
  podRetention:onFailure(),
  slaveConnectTimeout: '6000',
   resourceRequestCpu: '5000m',
        resourceLimitCpu: '10000m',
        resourceRequestMemory: '2024Mi',
        resourceLimitMemory: '10000Mi',
  ) {

  node(label) {
    stage('Pull the source code') {
         git url: 'https://github.com/subhashmeena/migration.git', credentialsId: 'GitCredentials'
    }
    
    stage('Building the solution') {
        bat 'dir'
        bat 'echo "Restoring the nuget packages"'
        bat 'nuget restore LiftAndShiftWcfApp.sln'
        bat 'echo "Building the solution"'
        bat 'msbuild /Target:build /p:Configuration=Release LiftAndShiftWcfApp.sln'
    }
    
    stage('Pulishing webapp') {
        dir('LiftAndShiftMvcApp.Web') {
            bat 'echo "Publishing the mvc web application"'
            bat 'msbuild /Target:package /p:Configuration=Release /p:AutoParameterizationWebConfigConnectionStrings=False'   
        }
        
    }
    
    stage('Publishing the wcf service') {
        dir('LiftAndShift.ProductService') {
            bat 'echo "Publishing the wcf service"'
            bat 'msbuild /Target:package /p:Configuration=Release /p:AutoParameterizationWebConfigConnectionStrings=False'
        }
    }
    
    stage('Building docker image for web app') {
        dir('LiftAndShiftMvcApp.Web') {
            withDockerServer([uri: '3.83.205.208:2376']) {
               withCredentials([usernamePassword(credentialsId: 'DockerCredentials', passwordVariable: 'DOCKER_HUB_PASSWORD', usernameVariable: 'DOCKER_HUB_USER')]) {
                    //bat "docker -H tcp://3.83.205.208:2376 login -u ${DOCKER_HUB_USER} -p ${DOCKER_HUB_PASSWORD}"
                    bat 'echo "Building the docker image for web app"'
                    bat 'docker build -t laxmikantk/webapp:latest -f Dockerfile obj\\Release\\Package\\PackageTmp'
                }
            }
        }
    }
    
    stage('Push docker image for web app to docker registry') {
        dir('LiftAndShiftMvcApp.Web') {
            withDockerServer([uri: '3.83.205.208:2376']) {
               withCredentials([usernamePassword(credentialsId: 'DockerCredentials', passwordVariable: 'DOCKER_HUB_PASSWORD', usernameVariable: 'DOCKER_HUB_USER')]) {
                    bat "docker login -u ${DOCKER_HUB_USER} -p ${DOCKER_HUB_PASSWORD}"
                    bat 'echo "Pushing the web app image to docker registry"'
                    bat 'docker push laxmikantk/webapp:latest'
                }
            }
        }
    }
    
    stage('Building wcf service image ') {
        dir('LiftAndShift.ProductService') {
            withDockerServer([uri: '3.83.205.208:2376']) {
               withCredentials([usernamePassword(credentialsId: 'DockerCredentials', passwordVariable: 'DOCKER_HUB_PASSWORD', usernameVariable: 'DOCKER_HUB_USER')]) {
                    bat "docker login -u ${DOCKER_HUB_USER} -p ${DOCKER_HUB_PASSWORD}"
                    bat 'echo "Building wcf service (product service) image "'
                    bat 'docker build -t laxmikantk/wcfservice:latest -f Dockerfile obj\\Release\\Package\\PackageTmp'
                }
            }
        }
    }
    
    stage('Push docker image for wcf service to docker registry') {
        dir('LiftAndShift.ProductService') {
            withDockerServer([uri: '3.83.205.208:2376']) {
               withCredentials([usernamePassword(credentialsId: 'DockerCredentials', passwordVariable: 'DOCKER_HUB_PASSWORD', usernameVariable: 'DOCKER_HUB_USER')]) {
                    bat "docker login -u ${DOCKER_HUB_USER} -p ${DOCKER_HUB_PASSWORD}"
                    bat 'echo "Pushing the wcf service image to docker registry"'
                    bat 'docker push laxmikantk/wcfservice:latest'
                }
            }
        }
    }
    
    
  }
}

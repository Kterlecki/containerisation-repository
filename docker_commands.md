### Docker Build
``dotnet build -t {Tag-To-Attach-To-Image} .``

#### If you want to provide path yo your Dockerfile
`` docker build -t {Tag-To-Attach-To-Image} -f /path/to/Dockerfile . ``

#### Build an image with no cache
`` docker build --no-cache -t {Tag-To-Attach-To-Image}  . ``

#### If you want to pass in build-time variables
`` docker build --build-arg VAR=value -t {Tag-To-Attach-To-Image} . ``

#### Remove an image
`` docker rmi {Tag-To-Attach-To-Image}``

#### Prune Images
`` docker image prune``

#### Prune Containers
`` docker container prune``


### Docker run
``docker run {Tag-To-Attach-To-Image}``

### Docker run Interactive mode
`` docker run -it {Tag-To-Attach-To-Image} /bin/sh ``

### Docker Compose build - must be docker Compose V2
`` docker compose build --no-cache``

### Docker Compose Run
`` docker compose up``

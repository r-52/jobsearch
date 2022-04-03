FROM ubuntu:21.10 as basic

ARG USERNAME=jobsearch
ARG USER_UID=1000
ARG USER_GID=$USER_UID

# Ensure apt is in non-interactive to avoid prompts
ENV DEBIAN_FRONTEND=noninteractive \
    DOTNET_RUNNING_IN_CONTAINER=true \
    DOTNET_USE_POLLING_FILE_WATCHER=true \
    NGET_XMLDOC_MODE=skip \
    NG_CLI_ANALYTICS=false


RUN apt-get -y update --no-install-recommends \
    && apt-get -y install --no-install-recommends \
    build-essential \
    curl \
    ca-certificates \
    apt-utils \
    dialog \
    git \
    vim \
    wget \
    apt-transport-https \
    && apt-get autoremove -y \
    && apt-get clean -y 

RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && dpkg -i packages-microsoft-prod.deb

RUN apt-get update \
    && apt-get install -y dotnet-sdk-6.0 \
    && dotnet tool install --global dotnet-ef \
    && dotnet dev-certs https --trust



RUN curl -sL https://deb.nodesource.com/setup_16.x | bash -


RUN apt-get -y update --no-install-recommends \
    && apt-get -y install --no-install-recommends nodejs \
    && apt-get autoremove -y \
    && apt-get clean -y



RUN groupadd --gid $USER_GID $USERNAME \
    && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME


EXPOSE 5000
EXPOSE 5001
EXPOSE 6006



RUN npm i -g @angular/cli && npm i -g @storybook/cli

WORKDIR /workspaces/jobsearch


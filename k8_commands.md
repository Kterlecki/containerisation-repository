# Kubernetes (kubectl) Commands

### Check kubectl client version
Shows the version of your kubectl client in YAML format.
```kubectl version --client=true -o yaml```

### List all API resources
Displays all available Kubernetes resource types.
```kubectl api-resources```

### List all namespaces
Lists all namespaces in the cluster.
```kubectl get ns```

### Create a new namespace
Creates a namespace with the specified name.
```kubectl create ns {namespace_name}```

### Apply a manifest file
Deploys resources defined in a YAML file.
```kubectl apply -f app.yml```

### Delete a namespace (destroy resources in it)
Deletes the specified namespace and all resources within it.
```kubectl delete ns {namespace_name}```

### Set default namespace for current context
Sets the default namespace for your current kubectl context.
```kubectl config set-context --current --namespace {namespace_name}```

### Reset to default namespace
Sets the default namespace back to 'default'.
```kubectl config set-context --current --namespace default```

### List services in kube-system namespace
Lists all services running in the kube-system namespace.
```kubectl get svc -n kube-system```

### Describe the default namespace
Shows detailed information about the 'default' namespace.
```kubectl describe ns default```
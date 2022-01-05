# Clean Architecture
This is an example project of Clean Architecture (CA) in .NET 6. 

Status: Work in Progress

# Setup
```
dotnet tool install -g Microsoft.Tye 
tye run
```


# Deploy with helm charts
## Install
```
helm install clean-architecture ./helm-charts
```

## Uninstall
```
helm uninstall clean-architecture
```


# Documentation
- [Layers](documentation/Layers.md)

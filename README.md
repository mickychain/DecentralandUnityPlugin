# Decentraland Unity Exporter

## Supported Elements

* Box

* Sphere

* Quad (will be exported as two-face planes)

* Cylinder

* TextMesh (custom font is not supported)

* so far, only the diffuse color of the default material is supported.

**Note: Sphere and Cylinder have a lot of triangles that will exceed dcl limit, so use them carefully.**

## Installation Guide

You should prepare these tools on your own:

1. [dcl SDK](https://docs.decentraland.org/documentation/installation-guide/)

1. [Unity 5.x\2017\2018 or higher](https://unity3d.com/)

Then, download the Exporter which is inside a Unity Package.

[Download the Exporter](https://github.com/fairwood/DecentralandUnityPlugin/blob/master/downloads/DecentralandUnityExporter.unitypackage)

## Exporter Guide

First, you have to create a Unity project, better empty.

Then drag the .unitypackage file into Unity or use "Import Assets.." in Unity. That will extract all assets into your Unity project.

After a while, you should see a new tab in the menu bar like below.

![](https://github.com/fairwood/DecentralandUnityPlugin/blob/master/docs/where_in_menu.jpg)

Click the "Scene Exporter" will open the exporter.

**Note:** an auto-generated GameObject called ".dcl" will be created in the hierarchy. Don't touch it.

You can create a new scene or open the sample scene:

![Exporter UI](https://github.com/fairwood/DecentralandUnityPlugin/blob/master/docs/samplescene.jpg)

The exporter looks like this:

![Exporter UI](https://github.com/fairwood/DecentralandUnityPlugin/blob/master/docs/exporter.jpg)

Edit your parcels' coordinates in the following format:
```
12,-21
12,-22
13,-21
13,-22
...
```

**The first line will be the "base" parcel set as the center in your scene.**

The warning function is not done yet. Just ignore it.

Input the path of the folder to export files.

2 files will be exported:

* scene.tsx

* scene.json

Click "Export" Button to export. If it succeeds, a log will be outputted to the Unity console.


## Thanks

### Support from Decentraland Team

Ari Meilich

[Esteban Ordano](https://github.com/eordano)

Matias Bargas

Chris Chapman

Jayson Hu

Diff

### Test Users

时光倒流

不异

### Unity-glTF Tools

[@neil3d/Unity-glTF-Exporter](https://github.com/neil3d/Unity-glTF-Exporter)



## （以下未完成）



## Installation Guide for Artists
1. Follow [DCL Installation Guide](https://docs.decentraland.org/documentation/installation-guide/)




## Install Other Tools

### 3DMax & glTF Exporter (excerpted from http://doc.babylonjs.com/resources/3dsmax)

Goto the github folder(https://github.com/BabylonJS/Exporters/tree/master/3ds%20Max).
Download Max2Babylon-x.x.xx.zip. That is the plugin for 3DMax
Then, extract the content of the zip file on your computer, and open the directory corresponding to your 3DS Max version. Finally, make sure 3ds Max is not running, and move all .dll files into the installation directory of 3DS Max (in C:/Programs/Autodesk/3ds Max 2015/bin/assemblies). The next time you will start 3ds Max, the plugin will be automatically launched, and a new tab should appear:
![](http://d33wubrfki0l68.cloudfront.net/fab1a8bca64e39331d0cfb507fe7b6a49a4ca8bb/bd49e/img/exporters/3dsmax/4_plugin_visible.jpg)


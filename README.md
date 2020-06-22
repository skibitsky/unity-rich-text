# Unity Rich Text [![openupm](https://img.shields.io/npm/v/com.skibitsky.unity-rich-text?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.skibitsky.unity-rich-text/)

Unity Rich Text allows you easily highlight any variable when using `Debug.Log` or any other place that supports rich text (i.e. GUIStyle or TextMeshPro).

![](https://imgur.com/EQGAzpx.jpeg)

It makes very easy to apply a few rich text tags at once.

Note that it creates a lot of garbage hence I don't recommend to use it in production.

## Installation

### Install via OpenUPM

The package is available on the [openupm registry](https://openupm.com). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

```
openupm add com.skibitsky.unity-rich-text
```

### Install via Git URL

Open *Packages/manifest.json* with your favorite text editor. Add the following line to the dependencies block.

    {
        "dependencies": {
            "com.skibitsky.unity-rich-text": "https://github.com/skibitsky/unity-rich-text.git"
        }
    }

Notice: Unity Package Manager records the current commit to a lock entry of the *manifest.json*. To update to the latest version, change the hash value manually or remove the lock entry to resolve the package.

    "lock": {
      "com.skibitsky.unity-rich-text": {
        "revision": "master",
        "hash": "..."
      }
    }


## Usage

```csharp
Debug.Log(17.Red().Bold()):
```

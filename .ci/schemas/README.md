### VSCode Plugin: Azure Pipelines

When use this VSCode plugin, pay attention to your custom organization Azure extensions. If you have some extra extension installed remotelly, add this full path to your user VSCode settings like this:

```js
// Linux: ~/.vscode/settings.json
// Windows: C:\\$HOME\\AppData\\Roaming\\Code\\User\\settings.json
{
  "[azure-pipelines].customSchemaFile": "C:\\[your-project-full-path]\\.ci\\schemas\\my-schema.json"
}
```
> **PS:** By now, this plugin not support relative paths :(

After that, create a file

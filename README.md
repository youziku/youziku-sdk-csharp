# 一、环境
.NET Framework版本：4.5

# 二、介绍

SDK适用于在C#语言中调用service.youziku.com中的所有api

# 三、Sample
## 1.初始化YouzikuServiceClient实例,在全局配置一遍即可
```csharp 
publci static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(apiKey: "xxxxxx");
```
## 2.单标签模式
### 2.1 GetFontface()
#### 备注:直接返回所有格式的@fontface
同步调用
``` csharp
var response = youzikuClient.GetFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing Inc.",
    Tag = "#gg"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "jamesbing Inc.",
      Tag = "#gg"
});
```
### 2.2 GetWoffBase64StringFontFace()
#### 备注：直接返回流（woff流）的@fontface
同步调用
``` csharp
var response = youzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing Inc.",
    Tag = "#gg"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "jamesbing Inc.",
      Tag = "#gg"
});
```
## 3.多标签生成模式
### 1.GetBatchFontFace()
#### 备注：直接返回所有格式的@fontface;可传递多个标签和内容一次生成多个@fontface
同步调用
``` csharp
//构建一个请求参数
var param = new BatchFontFaceParam();
//开始构建生成项
param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing1 Inc.",
    Tag = "#gg1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing2 Inc.",
    Tag = "#gg2"
});
var response =  youzikuClient.GetBatchFontFace(param);
```
异步调用
``` csharp
//构建一个请求参数
var param = new BatchFontFaceParam();
//开始构建生成项
param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing1 Inc.",
    Tag = "#gg1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing2 Inc.",
    Tag = "#gg2"
});
var response = await youzikuClient.GetBatchFontFaceAsync(param);
```
### 2.GetBatchWoffFontFace ()
#### 备注：直接返回仅woff格式的@fontface
同步调用
``` csharp
//构建一个请求参数
var param2 = new BatchFontFaceParam();
//开始构建生成项
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "jamesbing-woff-1 Inc.",
     Tag = "#t-woff-1"
});
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "jamesbing-woff-2 Inc.",
     Tag = "#t-woff-2"
});

var response =  youzikuClient.GetBatchWoffFontFace(param2);
```
异步调用
``` csharp
//构建一个请求参数
var param2 = new BatchFontFaceParam();
//开始构建生成项
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "jamesbing-woff-1 Inc.",
     Tag = "#t-woff-1"
});
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "jamesbing-woff-2 Inc.",
     Tag = "#t-woff-2"
});

var response = await youzikuClient.GetBatchWoffFontFaceAsync(param2);
```
## 4.自定义路径生成模式
### 1.CreateBatchWoffWebFontAsync()
#### 备注：自定义路径接口可以被程序异步调用，程序调用后可以直接向下执行，不需要等待返回值
同步调用
``` csharp
var cusParam = new BatchCustomPathWoffFontFaceParam();
cusParam.Datas.Add(new CustomPathFontFaceParam
{
      AccessKey = "xxx",
      Content = "jamesbingbing1 Inc.",
      Url = "jamesbing/test-1"
});
cusParam.Datas.Add(new CustomPathFontFaceParam
{
       AccessKey = "xxx",
       Content = "jamesbingbing2 Inc.",
       Url = "jamesbing/test-2"
});

var response =  youzikuClient.GetCustomPathBatchWoffWebFont(cusParam);
```
异步调用
``` csharp
var cusParam = new BatchCustomPathWoffFontFaceParam();
cusParam.Datas.Add(new CustomPathFontFaceParam
{
      AccessKey = "xxx",
      Content = "jamesbingbing1 Inc.",
      Url = "jamesbing/test-1"
});
cusParam.Datas.Add(new CustomPathFontFaceParam
{
       AccessKey = "xxx",
       Content = "jamesbingbing2 Inc.",
       Url = "jamesbing/test-2"
});

var response = await youzikuClient.GetCustomPathBatchWoffWebFontAsync(cusParam);
```

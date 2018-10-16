﻿# 一、介绍

## 1．SDK适用语言<br/>
SDK适用于在C#(或其他.NET框架下语言)中调用<a  target="_blank"  href="http://service.youziku.com">service.youziku.com</a>中的所有api<br/>

## 2.工作流程<br/>　
   ①用户用后端程序调用SDK，提交动态内容到有字库的子集化(裁切)服务器<br/>
   ②服务器接收到所提交内容后，根据内容裁剪出对应的小字体文件，并转换为4种通用字体格式（woff、eot、ttf、svg）<br/>
   ③服务器将所有字体文件按用户指定的地址上传至阿里云CDN<br/>
   ④用户使用字体时，用自定义的路径，参照@font-face格式来拼出能兼容所有浏览器的@font-face语句<br/>
## 3.@font-face语句<br/>
SDK的返回值主要内容是@font-face语句，@font-face语句是CSS3中的一个功能模块，是所有浏览器天然支持的CSS语句。它的作用是将一个远程字体文件加载到当前页面，并且定义成一个字体，前端页面能够像使用本地字体一样使用该字体。@font-face语句是实现在线字体效果的核心代码。<br/>

## 4. 显示字体效果
用户<a href="#user-content-4自定义路径生成模式">自定义字体存放路径</a>，当需要显示字体效果时，可以根据自己所定义的路径<a href="http://service.youziku.com/index.html#format" target="_blank" style="color: #ff7e00;">拼组出@font-face语句</a>，然后将语句输出到前端页面，即可使内容显示字体效果。

# 二、环境
1. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk下载/Youziku.SDK.v35.zip">下载SDK</a>(兼容.NET Framework version 3.5及以上所有版本；) <br />
2. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk下载/Youziku.SDK.v45.zip">下载SDK</a>(兼容.NET Framework version 4.5及以上所有版本；增加对异步调用[使用async和await]的支持)

# 三、引用
## 1.添加引用

# 四、Sample
## 1.初始化YouzikuServiceClient实例,在全局配置一遍即可
```csharp 
public static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient("xxxxxx");//apiKey
```

## 2.调用接口(接口分为5种模式，用户可任选一种)
### 2.1.敏捷模式-多标签woff接口：CreateBatchWoffWebFontAsync()
#### 备注：敏捷模式接口可以被程序异步调用，程序调用后可以直接向下执行，不需要等待返回值
#### &emsp;&emsp;&emsp;当需要显示字体效果时，可以根据自己所定义的路径<a href="http://service.youziku.com/index.html#format" target="_blank" style="color: #ff7e00;">拼组出@font-face语句</a>，然后将语句输出到前端页面，即可使内容显示字体效果。
同步调用
``` csharp
//构建一个请求参数
var cusParam = new BatchCustomPathWoffFontFaceParam();
//开始构建生成项
cusParam.Datas.Add(new CustomPathFontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Url = "youziku/test-1"
});
cusParam.Datas.Add(new CustomPathFontFaceParam
{
       AccessKey = "xxx",
       Content = "有字库，让前端掌控字体！",
       Url = "youziku/test-2"
});

var response =  youzikuClient.GetCustomPathBatchWoffWebFont(cusParam);
```
异步调用
``` csharp
//构建一个请求参数
var cusParam = new BatchCustomPathWoffFontFaceParam();
//开始构建生成项
cusParam.Datas.Add(new CustomPathFontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Url = "youziku/test-1"
});
cusParam.Datas.Add(new CustomPathFontFaceParam
{
       AccessKey = "xxx",
       Content = "有字库，让前端掌控字体！",
       Url = "youziku/test-2"
});

var response = await youzikuClient.GetCustomPathBatchWoffWebFont(cusParam);
```

### 2.2 语句绑定模式-单标签接口：GetFontface()
#### 备注:直接返回所有格式的@fontface
同步调用
``` csharp
var response = youzikuClient.GetFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Tag = "#id1"
});
```
### 2.3 语句绑定模式-单标签Base64接口：GetWoffBase64StringFontFace()
#### 备注：直接返回Base64流（woff流）的@fontface
同步调用
``` csharp
var response = youzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Tag = "#id1"
});
```

### 2.4 语句绑定模式-多标签接口：GetBatchFontFace()
#### 备注：直接返回所有格式的@fontface;可传递多个标签和内容一次生成多个@fontface
同步调用
``` csharp
//构建一个请求参数
var param = new BatchFontFaceParam();
//开始构建生成项
param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让前端掌控字体！",
    Tag = ".class1"
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
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让前端掌控字体！",
    Tag = ".class1"
});
var response = await youzikuClient.GetBatchFontFaceAsync(param);
```
### 2.5 语句绑定模式-多标签woff格式接口：GetBatchWoffFontFace ()
#### 备注：直接返回仅woff格式的@fontface
同步调用
``` csharp
//构建一个请求参数
var param2 = new BatchFontFaceParam();
//开始构建生成项
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让中文跃上云端！",
     Tag = "#id1"
});
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让前端掌控字体！",
     Tag = ".class1"
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
     Content = "有字库，让中文跃上云端！",
     Tag = "#id1"
});
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让前端掌控字体！",
     Tag = ".class1"
});

var response = await youzikuClient.GetBatchWoffFontFaceAsync(param2);
```

# 1、介绍

### SDK适用语言
SDK适用于在C#(或其他.NET框架下语言)中调用字体子集化方法。

### 显示字体效果
用户可自定义字体存放路径，当需要显示字体效果时，可以根据自己当初所定义的路径拼组出@font-face语句，然后将语句插入到前端页面的<style>标签中，即可使内容显示字体效果。

### @font-face语句拼组
@font-face语句拼组格式如下：
```css
@font-face
{
    font-family: '{fontfamilyname}';
    src:url(https://cdn.repository.webfont.com/webfonts/custompath/{UserKey}/{Url}.gif);
    src:url(https://cdn.repository.webfont.com/webfonts/custompath/{UserKey}/{Url}.gif#iefix) format('embedded-opentype'),
    url(https://cdn.repository.webfont.com/webfonts/custompath/{UserKey}/{Url}.png) format('woff2'),
    url(https://cdn.repository.webfont.com/webfonts/custompath/{UserKey}/{Url}.bmp) format('woff'),
    url(https://cdn.repository.webfont.com/webfonts/custompath/{UserKey}/{Url}.jpg) format('truetype');
}

/* 
{fontfamilyname}是由用户自定义的；它就是WebFont所创建的字体的名字，当某个标签要引用这个WebFont时，font-family必须与它一致；同一页面，不能重复创建相同的{fontfamilyname}。

{UserKey}是服务器为每个用户专门开僻的存储空间的名字，UserKey可以从用户后台获取。

{Url}即是调用接口时所提交的参数(url)。
*/
```
例如：
```css
@font-face
{
    font-family: 'NotoSansCJKsc-light';
    src:url(https://cdn.repository.webfont.com/webfonts/custompath/89B7CC9B4E975C85/page15.gif);
    src:url(https://cdn.repository.webfont.com/webfonts/custompath/89B7CC9B4E975C85/page15.gif#iefix) format('embedded-opentype'),
    url(https://cdn.repository.webfont.com/webfonts/custompath/89B7CC9B4E975C85/page15.png) format('woff2'),
    url(https://cdn.repository.webfont.com/webfonts/custompath/89B7CC9B4E975C85/page15.bmp) format('woff'),
    url(https://cdn.repository.webfont.com/webfonts/custompath/89B7CC9B4E975C85/page15.jpg) format('truetype');
}
```


# 2、环境
1. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk下载/Youziku.SDK.v35.zip">下载SDK</a>(兼容.NET Framework version 3.5及以上所有版本；) <br />
2. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk下载/Youziku.SDK.v45.zip">下载SDK</a>(兼容.NET Framework version 4.5及以上所有版本；增加对异步调用[使用async和await]的支持)

# 3、引用
## 1.添加引用

# 4、Sample
## 1.初始化YouzikuServiceClient实例,在全局配置一遍即可
```csharp 
public static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient("xxxxxx");//apiKey
```

## 2.调用接口(接口分为5种模式，用户可任选一种)
### 2.1.敏捷模式-多标签woff接口：CreateBatchWoffWebFontAsync()
#### 备注：敏捷模式接口可以被程序异步调用，程序调用后可以直接向下执行，不需要等待返回值
#### &emsp;&emsp;&emsp;当需要显示字体效果时，可以根据自己所定义的路径<a href="http://service.youziku.com/index.html#format" target="_blank" style="color: #ff7e00;">拼组出@font-face语句</a>，然后将语句输出到前端页面，即可使内容显示字体效果。

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


### 2.2 语句绑定模式-单标签接口：GetFontface()
#### 备注:直接返回所有格式的@fontface

``` csharp
var response = youzikuClient.GetFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});
```

### 2.3 语句绑定模式-单标签Base64接口：GetWoffBase64StringFontFace()
#### 备注：直接返回Base64流（woff流）的@fontface

``` csharp
var response = youzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});
```


### 2.4 语句绑定模式-多标签接口：GetBatchFontFace()
#### 备注：直接返回所有格式的@fontface;可传递多个标签和内容一次生成多个@fontface

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

### 2.5 语句绑定模式-多标签woff格式接口：GetBatchWoffFontFace ()
#### 备注：直接返回仅woff格式的@fontface

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

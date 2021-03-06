# InfoFile-Solution
You can add info to your file freely with this new project!

信息附加文件，给你的文件添加多样化的附加信息！

***

这是我写的第一个C#练习项目，兴趣使然，代码如有不足之处欢迎指出，同时，**理解万岁**(/▽＼)！

## 这个项目的具体功能？
在这个解决方案里包含了四个项目，旨在让我们给自己电脑上的文件📄或文件夹📂添加各种附加信息，包括但不限于文本📃、图片🎨、富文本🎫、媒体🎵🎦、标签🏷、链接🔗、文件关联📑等。

>当你面对一整文件夹的压缩包时，是否会因为筛选不到自己想要的，或是无法得知文件的摘要信息而痛苦？

>在这个文件的基础上，你可以使用相关类库在自己想要的方面进行特化扩展，只要你敢想，~~就能够写得比我更好~~

>需要灵感点播参见下文


## 这四个项目都是什么？
目前只有四个项目，今后可能会增加更多。下面我将详细解释每个项目的作用和开发进度：

### **InfoFileFormat** 
附加信息文件的类库，用于实现信息的添加、转换、读取、存储。
  - **开发进度**：能正常使用，但后续功能有待优化和完善
  - **类库**

### **InfoFileExplorer** 
文件附加信息查看器，用于查看文件附加信息（仅查看）
  - **开发进度**：起步阶段，刚刚完成信息的显示
  - **WPF**

### **FileFinder** 
一个文件搜索工具，可在指定范围内，通过文件大小、md5、模糊文件名等搜索某文件的位置。用于在将文件重命名或移动后尝试重新定位文件。

（文件格式原因，附加信息必须用单独的文件存放，所以衍生出了这个项目）
  - **开发进度**：新建文件夹
  - **类库**

### **RJ Manager** 妈呀我怎么把这个也上传上来了Σ(っ °Д °;)っ。
一个通过RJ number管理指定范围内DLsite作品的软件，是我真正意义上的第一个C#项目。

本来是拿来自己玩的，不过发上来了的话就看看能不能帮助到几个人吧(/ω＼\*)……… (/ω•＼\*)

目前可用于通过文件名中包含的RJ号来显示作品名称和预览图，并对作品进行筛选（计划未来改用InfoFile文件来对作品进行筛选和管理）。

  - **开发进度**：绝大部分功能可用，如果没接触过DLsite相关内容的请不要使用，看看就好（；´д｀）ゞ
  - **WinForm**


## 那么……我该如何使用呢？
我不知道，我又没发布过（理直气壮(* ￣︿￣)）

欸等等等等……别打我X﹏X

因为现在还没有写文档，所以只能研究着代码用了……抱歉(ノへ￣、)


## 我可以用这些附加信息实现哪些拓展功能？给点灵感？
有很多呀，就拿那个RJ Manager举例子好了OwO
- 我可以通过在附加信息中加入**解压密码**，然后在代码实现中自动根据密码解压

- 我可以通过在附加信息中加入**来源链接**，提醒我是在哪个网站或哪一篇帖子下载的

- 我可以通过在附加信息中加入**图片**，来告诉我这个作品的大概内容

- 我可以通过在附加信息中加入**作者信息**，然后在代码实现中进行筛选

- 我可以通过在附加信息中加入一些**标签**，然后在代码实现中用标签来筛选内容

- 我可以通过在附加信息中加入**文件关联**，来提醒自己有多个文件是同一个作品的不同部分

- 我可以通过在附加信息中加入**备注**，来告诉自己对这部作品的个人感受

- *~~我也可以将附加信息一同分享给别人，然后让自己社会性死亡~~*


## 之后计划加入什么功能呢？
目前能想到的有：
- 制作一个**筛选器**，可以方便使用者对文件进行筛选

- 制作一套规范的规范，类似于**接口**，让每个不同类型的文件使用特定标准的附加信息
  - 简单举个例子，如果是从资源网站上下载的压缩文件，都要标注原帖链接和解压密码等，这样就可以在自己开发的软件中直接使用这些信息，而不必因为没有标准规范而一个个判断。

- 添加**标签**功能

- 在附加信息内加入**媒体**（如音乐、视频等）

- 对附加信息进行**加密**

- 练习一下WPF的设计类功能，**美化软件界面**

- 添加图片组、文本组等**数组**信息，因为有些信息可能需要附加多张图片

还有一些一般能想到，但现在**忘了**(⊙﹏⊙)


## 相关文档什么时候完善？

等该库有一个**非熟人**的Star⭐后，之后还会根据需求制作wiki。<br>


# 版权信息
本作品作者为该github账号以及以上个人链接账号截至2021/4/6的法定所有者。

Author：Wshine

同名者不算在作者行列内


使用 [**GNU General Public License v2.0**](http://www.gnu.org/licenses/old-licenses/gpl-2.0.html) 开源协议

# InterLang
A programming language with dynamic syntax that can compile to a wide variety of existing languages.

## What is the point?
The point of InterLang is to have an easy to learn language that builds around different programmers needs and wants.

## Why was it created?
InterLang was created to have a "one language fits all" solution to programming. The main part of InterLang that will make it work so well is that it admits there is no perfect language for everything.

## How does it work?
Programmers will write easy to use code in InterLang, which is not technically one language, however there will be a default language. The reason InterLang is good for a wide variety of programmers is that it has dynamic syntax. This means that the syntax is determined by values that the programmer can choose in a meta file. The compiler will use the meta file to decide how the true code should be compiled. This variable InterLang code gets translated into the default InterLang, to allow it to be compiled in the next step. InterLang then is able to compile to many different languages, such as C#, Python, and JavaScript.

## Why is this a good thing?
Having this "one langauge fits all solution" means that developers can write code how *they* want to. It also means that a team of developers can write in different subsets of InterLang and al compile to the same language, allowing more efficiency within those teams. Furthermore, the default syntax of InterLang may be a good option for beginner programmers, as it will be simple. InterLang will also have the advantage of portability, this is because of the wide variety of compilation targets InterLang will have. This means that if a target machine can't run the JavaScript version of the code, you can create an executable instead. This also makes full-stack development easier, since the written code can run in most places (e.g. broswer).

## What does default InterLang look like?
Here is some code for the default InterLang.

```
for 10
  output("Hello, World!")
```

From this code many developers may be annoyed with the syntax, especially if they are more experienced. This is why the "one language fits all" concept doesn't work all the time, and why dynamic syntax is key. Here is an alternative that can be achieved by utilising the meta file.

```
for 10 as i {
  print("Hello, World!")
}
```

Or even...

```
for (i = 0 < 10):
  Console.WriteLine("Hello, World!")
```

This fixes many subjective subjects in languages, semicolons, curly braces, etc.
InterLang, as it is to compile to many languages, can also get inspiration from many languages or build off of them, such as this class declaration:

```
cls Point(int ix:x, int iy:y)
```

This single line of InterLang can translate to Python as such, which can decrease boilerplate that is common with many languages.

```python
class Point:
  def __init__(self, ix, iy):
    self.x = ix
    self.y = iy
```

## Conclusion
This project may bring productivity to a variety of situations, but in order to be usable there needs to be considerable input to make it a reality. If you a passoinate about a project like this, do not hesitate to give ideas and code to help bring this project along. The best part is, you can contribute in any language, since InterLang can do the work of translating it for you.

# Assignment 0 - Deep Stack

This code is from a tutorial from Microsoft about C# and OOP principles. Although I copied and pasted most of the code, I inadvertently created bugs in the process. So in the end, this tutorial expanded my abilities and confidence, well, not so much confidence :)

---

## Links to Sources

[**BankAccount Tutorial - Part 1**](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes)

[**BankAccount Tutorial - Part 2**](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

---

## Questions

**1 - I don't understand how to chain constructors.**

**2 - Wouldn't it be better to convert BankAccount to an abstract class?**

I started to convert the application to a console application in which the user could select type of account from an enum. However I got confused while writing constructors. As currently built, user can create an account from the base class or a derived class which means that "AccountType" may be set twice. I was confused about where to locate the enum so both the base class and derived class could have access. I guess I need more practice with polymorphism.

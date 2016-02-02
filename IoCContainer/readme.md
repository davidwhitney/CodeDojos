# Inversion of Control Containers

In software engineering, inversion of control (IoC) describes a design in which custom-written portions of a computer program receive the flow of control from a generic, reusable library. A software architecture with this design inverts control as compared to traditional procedural programming: in traditional programming, the custom code that expresses the purpose of the program calls into reusable libraries to take care of generic tasks, but with inversion of control, it is the reusable code that calls into the custom, or task-specific, code.

Inversion of control is used to increase modularity of the program and make it extensible, and has applications in object-oriented programming and other programming paradigms. The term was popularized by Robert C. Martin and Martin Fowler. The term is related to but different from the dependency inversion principle, which concerns itself with decoupling dependencies between high-level and low-level layers through shared abstractions.

(Source: Wikipedia)

---
## An example

From Stackoverflow - http://stackoverflow.com/questions/3058/what-is-inversion-of-control

The Inversion of Control (IoC) and Dependency Injection (DI) patterns are all about removing dependencies from your code.

For example, say your application has a text editor component and you want to provide spell checking. Your standard code would look something like this:

```csharp
public class TextEditor
{
    private SpellChecker _checker;
    
    public TextEditor()
    {
        _checker = new SpellChecker();
    }
}
```

What we've done here is create a dependency between the TextEditor and the SpellChecker. In an IoC scenario we would instead do something like this:

```csharp
public class TextEditor
{
    private ISpellChecker _checker;
    
    public TextEditor(ISpellChecker checker)
    {
        _checker = checker;
    }
}
```

Now, the client creating the TextEditor class has the control over which SpellChecker implementation to use. We're injecting the TextEditor with the dependency.

---

## IoC Containers

IoC containers are tools that help you implement the *dependency inversion principle* - normally acting as some kind of registry for components in your code.

Generally, containers work in the following way:

* You register your components with your container
* When you need to construct a class, you ask your container to give you an instance of the class
* Any dependencies are automatically resolved and created for you
* Dependencies are resolved via constructor injection or property injection

---

# Implement a simple IoC container!

### Story 1 - Create a class with no constructor parameters

``` 
As a developer
When I ask my container for an instance of Foo
I get an instance of Foo
```

### Story 2 - Create a class with constructor parameters

``` 
As a developer
When I ask my container for an instance of Foo, where Foo depends on Bar
I get an instance of Foo
```

### Story 3 - Create a class with a dependency on an interface

``` 
As a developer
When I ask my container for an instance of Foo, where Foo depends on IBar
I get an instance of Foo
```

### Story 4 - Clashing dependencies

``` 
As a developer
When I ask my container for an instance of Foo, where Foo depends on IBar
And there are multiple implementations of IBar
I get an error explaining why I couldn't create Foo
```

### Story 5 - Registrations

``` 
As a developer
When I ask my container for an instance of Foo, where Foo depends on IBar
I can tell the container which instance of IBar to use
```

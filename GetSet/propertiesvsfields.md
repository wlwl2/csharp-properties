# Properties vs Fields

https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property

Object orientated programming principles say that, the internal workings of a
class should be hidden from the outside world. If you expose a field you're in
essence exposing the internal implementation of the class. Therefore we wrap
fields with Properties (or methods in Java's case) to give us the ability to
change the implementation without breaking code depending on us. Seeing as we
can put logic in the Property also allows us to perform validation logic etc. if
we need it. C# 3 has the possibly confusing notion of auto-properties. This
allows us to simply define the Property and the C# compiler will generate the
private field for us.


Properties expose fields. Fields should (almost always) be kept private to a
class and accessed via get and set properties. Properties provide a level of
abstraction allowing you to change the fields while not affecting the external
way they are accessed by the things that use your class.

```cs
public class MyClass
{
    // this is a field.  It is private to your class and stores the actual data.
    private string month;

    // this is a property. When accessed it uses the underlying field,
    // but only exposes the contract, which will not be affected by the
    // underlying field.
    public string Month
    {
        get
        {
            return month;
        }
        set
        {
            month = value;
        }
    }

    // This is an Auto-implemented property (C# 3.0 and higher) - which is a shorthand syntax
    // used to generate a private field for you
    public int Year { get; set; }
}
```

Properties are not required to encapsulate fields, they could do a calculation
on other fields, or serve other purposes.

You can also do other logic, such as validation, when a property is accessed,
another useful feature.

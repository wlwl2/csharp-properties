# C# Properties

A `get` property accessor is used to return the property value.

A `set` property accessor is used to assign a new value.

These accessors can have different access levels.

The `value` keyword is used to define the value being
assigned by the set accessor.

Properties can be read-write (they have both a get and a set accessor),
read-only (they have a get accessor but no set accessor), or write-only (they
have a set accessor, but no get accessor). Write-only properties are rare and
are most commonly used to restrict access to sensitive data.

# Auto-implemented properties

`public int AutoImplementedProperty { get; set; }`

In some cases, property get and set accessors just
assign a value to or retrieve a value from a backing field without including any
additional logic. By using auto-implemented properties, you can simplify your
code while having the C# compiler transparently provide the backing field for
you.

## Remarks

Properties can be marked as public, private, protected, internal, protected
internal or private protected. These access modifiers define how users of the
class can access the property. The get and set accessors for the same property
may have different access modifiers. For example, the get may be public to allow
read-only access from outside the type, and the set may be private or protected.

- public
  - Access is not restricted.
- protected
  - Access is limited to the containing class or types derived from the
  containing class.
- internal
  - Access is limited to the current assembly.
- protected internal
  - Access is limited to the current assembly or types derived from the
  containing class.
- private
  - Access is limited to the containing type.
- private protected
  - Access is limited to the containing class or types derived from the
  containing class within the current assembly. Available since C# 7.2.

A property may be declared as a static property by using the static keyword.
This makes the property available to callers at any time, even if no instance of
the class exists. For more information, see Static Classes and Static Class
Members.

A property may be marked as a virtual property by using the virtual keyword.
This enables derived classes to override the property behavior by using the
override keyword. For more information about these options, see Inheritance.

A property overriding a virtual property can also be sealed, specifying that for
derived classes it is no longer virtual. Lastly, a property can be declared
abstract. This means that there is no implementation in the class, and derived
classes must write their own implementation. For more information about these
options, see Abstract and Sealed Classes and Class Members.

**Note**

It is an error to use a virtual, abstract, or override modifier on an accessor
of a static property.

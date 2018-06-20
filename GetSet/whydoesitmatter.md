Properties vs Fields – Why Does it Matter? (Jonathan Aneja)

September 4, 2009 by VBTeam

The other day I got an email from a developer asking an interesting question
about VB10’s Auto-implemented Properties feature.

“I am, however, somewhat confused regarding the properties feature you mentioned –
i.e. turning 11 lines of get/set/backing variable into one line. Wouldn’t this
be exactly the same as the existing functionality of creating a public variable?
I see no benefit for using a property in this case, except perhaps for the sake
of what some would consider best practice.”

On the surface there doesn’t seem to be a big difference between this:

Public Property Name() As String

And this:

Public Name() As String

Clearly both will expose an object’s state to the outside world, and can be
read/modified using the exact same syntax. Which then begs the question, why
would I ever use a property if I have no special logic in the Getter/Setter?

Let’s consider some reasons:

1. Fields can’t be used in Interfaces

You can’t enforce the existence of a field in an object’s public contract
through an interface. For properties though it works fine.

2. Validation

While your application currently may not require any validation logic to set a
particular value, changing business requirements may require inserting this
logic later. At that point changing a field to a property is a breaking change
for consumers of your API. (For example if someone was inspecting your class via
reflection).

3. Binary Serialization

Changing a field to a property is a breaking change if you’re using binary
serialization. Incidentally, this is one of the reasons VB10’s auto-implemented
properties have a “bindable” backing field (i.e. you can express the name of the
backing field in code) – that way, if you change an auto-implemented property to
an expanded property, you can still maintain serialization compatibility by
keeping the backing field name the same (in C# you’re forced to change it
because it generates backing fields with unbindable names).

4. A lot of the .NET databinding infrastructure binds to properties but not
fields

I’ve heard arguments on both sides as to whether or not that’s a good thing, but
the reality is that’s the way it works right now.

5. Exposing a public field is an FxCop violation

For many of the reasons listed above 🙂

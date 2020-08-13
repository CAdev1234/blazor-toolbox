so what i see here

is like 2 sever controls

one control being the header

and another server control being the entry control

i will explain the redline in a minute

so for these two controls

1st one, named (HeaderFormControl)

and 2nd one named TextEntryFormControl

The HeaderFormControl will have a property named Title

the TextEntryFormControl will have properties : HeaderText and EntryText
for our server controls we will inherit from an interface IFormControl (this will make sense a bit later)

and then we have essential say a class called FormsControls , that will hold a collection of all server controls

now this collection also holds another server control

we will call this DroppableFormAreaControl

this will inherit from interface IDroppableFormArea

so when we render the collection to the client , we have a server control, then one of these DroppableFormAreaControls in the collection .... then another server control, and another DroppableFormAreaControl and so on

the DroppableFormAreaControl will be like our red line in that image .... it goes in between server control

so when we drag a normal server control (IFormControl) , our acceptable drop targets is only IDroppableFormAreaControl

we don't allow another IFormControl to be a valid drop target

let me get the other link i have that has this drag drop stuff in it

https://chrissainty.com/investigating-drag-and-drop-with-blazor/

i'm not sure if they do this webassembly or on server

but we should be able to store positions etc on server

the second image .... shows like a dotted grey box .... think of this like our DroppableFormAreaControl

its height maybe 5 pixels or so

and full width

when we drag an IFormControl, over a valid droppable area then we can change the box dash to say green dashed , to indicate a valid drop target

then we just drop and reposition on these

sounds ok?
I

so first project , is for the above .... we will hard code a list of fixed fields (created on the server as a test)

and then that allows us to reposition etc

thats the aim of the first phase

then later, we will go on to like 2 column droppable rows etc ,... but that will be in another project

remember blazor (server) and not webassembly for this.
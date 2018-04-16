https://www.c-sharpcorner.com/UploadFile/pranayamr/overview-of-interface-segregation-principle/

The principle says “Client (class implementation interface) should not force to implement
Interface that they don't use.” In simple words the principle is saying, do not design a
big fat interface that forces the client to implement a method that is not required by it,
instead design a small interface. So by doing this class only implement the required
set of interface(s). 

If there is big fat interface then break it into a set of small interfaces with the related
method(s) in it. It's similar to normalizing our database like normalizing database from
1NF to 3NF where a big table is broken into tables with related columns.

Interface Segregation Principle in Real life
============================================

watch the link.
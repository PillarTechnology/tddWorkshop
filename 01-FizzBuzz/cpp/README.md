



## Setting Up a Development Environment

### OSX

You will need to install xcode command line utilities.  Type

    cc --version

If you get a response back about a version of clang or gcc, you already have
the tools installed.  Otherwise follow the instructions given on the command
line.


### Linux

At a command prompt, type

    gcc --version

If you get a version response back, you already have the tools installed.  If
you get any other response, install the necessary tools with

    apt install build-essential


### Windows

You will need [chocolatey](https://chocolatey.org/) installed.  Run these
commands from a window with administrative permissions:

    choco install mingw64 make


## Building and Testing

This repository is built with the GNU "make" utility.  To build and test the
software, issue the following command:

    make

You will either see and error message, or if your syntax is correct, you will
see a stream of text telling you about passed and failed tests.

## Editing Tools

The world is full of wonderful IDEs for C and C++.  Probably more than for any
other language.  To keep things simple, I strongly recommend using a minimalist
programming editor, such as vi, emacs, or VS Code.  This repo was written with
a combination of vi and VS Code.

If you are using VS Code I recommend having at least the C/C++ plugin from
Microsoft, and the Clang-Format plugin to neaten up your code.

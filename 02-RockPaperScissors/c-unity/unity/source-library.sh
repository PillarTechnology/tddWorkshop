#!/bin/sh

LIBRARYSRC=../unity-src

git clone https://github.com/ThrowTheSwitch/Unity.git ${LIBRARYSRC}

cp ${LIBRARYSRC}/src/*.c .
cp ${LIBRARYSRC}/src/*.h .
cp ${LIBRARYSRC}/extras/fixture/src/*.c .
cp ${LIBRARYSRC}/extras/fixture/src/*.h .
cp ${LIBRARYSRC}/extras/memory/src/*.c .
cp ${LIBRARYSRC}/extras/memory/src/*.h .

rm -rf ${LIBRARYSRC}

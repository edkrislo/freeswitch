# 
# The contents of this file are subject to the Mozilla Public
# License Version 1.1 (the "License"); you may not use this file
# except in compliance with the License. You may obtain a copy
# of the License at http://www.mozilla.org/MPL/
# 
# Software distributed under the License is distributed on an
# "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
# implied. See the License for the specific language governing
# rights and limitations under the License.
# 
# The Original Code is State Machine Compiler (SMC).
# 
# The Initial Developer of the Original Code is Charles W. Rapp.
# Portions created by Charles W. Rapp are
# Copyright (C) 2007. Charles W. Rapp.
# All Rights Reserved.
# 
# Contributor(s):
#   Chris Liscio
#
# RCS ID
# $Id: Makefile,v 1.2 2007/01/15 16:58:57 cwrapp Exp $
#
# CHANGE LOG
# (See the bottom of this file.)
#

TARGET    = checkstring

GCC       = gcc
CPPFLAGS  = -g -I../../../lib/ObjC/ -framework Foundation
SMC       = java -jar ../../../bin/Smc.jar
SMCFLAGS  = -objc -g

FSMS      = AppClass.sm
SOURCES   = $(FSMS:.sm=_sm.m) AppClass.m main.m ../../../lib/ObjC/statemap.m
HEADERS   = $(FSMS:.sm=_sm.h) AppClass.h
OBJECTS   = $(SOURCES:.m=.o)

##############

%_sm.h %_sm.m : %.sm
		$(SMC) $(SMCFLAGS) $<

all :		$(TARGET) test

$(TARGET) :	$(HEADERS) $(SOURCES)
		$(GCC) $(CPPFLAGS) -o $@ $(SOURCES)

test :		$(TARGET)
		-checkstring ""
		-checkstring 00
		-checkstring 1c
		-checkstring c0
		-checkstring abcba
		-checkstring 110010c010011
		-checkstring 110010c110010

clean :
		-rm -f $(TARGET) $(OBJECTS) *_sm.h *_sm.m

#
# CHANGE LOG
# $Log: Makefile,v $
# Revision 1.2  2007/01/15 16:58:57  cwrapp
# Release 4.4.0 second commit.
#
# Revision 1.1  2007/01/15 00:23:49  cwrapp
# Release 4.4.0 initial commit.
#

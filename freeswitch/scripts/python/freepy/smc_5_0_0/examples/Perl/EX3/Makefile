#
# The contents of this file are subject to the Mozilla Public
# License Version 1.1 (the "License"); you may not use this file
# except in compliance with the License. You may obtain a copy of
# the License at http://www.mozilla.org/MPL/
#
# Software distributed under the License is distributed on an "AS
# IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
# implied. See the License for the specific language governing
# rights and limitations under the License.
#
# The Original Code is State Machine Compiler (SMC).
#
# The Initial Developer of the Original Code is Charles W. Rapp.
# Portions created by Charles W. Rapp are
# Copyright (C) 2000 Charles W. Rapp.
# All Rights Reserved.
#
# Contributor(s):
#       Port to Perl by Francois Perrad, francois.perrad@gadz.org
#
# RCS ID
# $Id: Makefile,v 1.2 2007/01/03 14:37:39 fperrad Exp $
#
# CHANGE LOG
# $Log: Makefile,v $
# Revision 1.2  2007/01/03 14:37:39  fperrad
# + Added -reflect option for Perl, Python and Ruby code generation
#
# Revision 1.1  2005/06/16 18:04:15  fperrad
# Added Perl examples 1 - 4 and 7.
#
#

SM_SOURCES=     AppClass.sm
SOURCES=        $(SM_SOURCES:%.sm=%_sm.pm)

# Uncomment to turn on reflection.
# REFLECT = 	-reflect

SMC=            java -jar ../../../bin/Smc.jar
SMC_FLAGS=      -perl -g $(REFLECT)

all :           checkstring

%_sm.pm : %.sm
		$(SMC) $(SMC_FLAGS) $<

checkstring :   $(SOURCES)

clean :
		-rm *_sm.pm

test:
		-perl -w checkstring.pl ""
		-perl -w checkstring.pl 00
		-perl -w checkstring.pl 1c
		-perl -w checkstring.pl c0
		-perl -w checkstring.pl abcba
		-perl -w checkstring.pl 110010c010011
		-perl -w checkstring.pl 110010c110010

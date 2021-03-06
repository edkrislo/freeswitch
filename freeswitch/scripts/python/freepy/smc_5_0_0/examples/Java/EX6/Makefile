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
# Copyright (C) 2000 - 2006. Charles W. Rapp.
# All Rights Reserved.
# 
# Contributor(s):
#
# RCS ID
# $Id: Makefile,v 1.8 2006/09/17 16:26:06 cwrapp Exp $
#
# CHANGE LOG
# (See the bottom of this file.)
#

#################################################################
# Macros.
#

TARGET=		tcpdemo
SM_SOURCES=	TcpConnection.sm

SOURCES=	$(SM_SOURCES:%.sm=%Context.java) \
		AsyncTimer.java \
		TimerListener.java \
		AsyncDatagramSocket.java \
		DatagramSocketListener.java \
		TcpSegment.java \
		TcpConnection.java \
		TcpConnectionListener.java \
		TcpClient.java \
		TcpServer.java \
		client.java \
		server.java

CLIENT_JAR=	client.jar
SERVER_JAR=	server.jar

PACKAGE_DIR=	smc_ex6

FSM_LIB_DIR=	../../../lib

JAVAC=		javac
JAVAC_FLAGS=	-d . -g -classpath $(FSM_LIB_DIR)

# REFLECTION
# Uncomment following line to test reflection
# REFLECT=	-reflect

SMC=		java -jar ../../../bin/Smc.jar
SMC_FLAGS=	-java -g -sync $(REFLECT)

JAR=		jar
JAR_CREATE_FLAGS=	cmf
JAR_UPDATE_FLAGS=	uf

#################################################################
# Rules.
#

all :		$(TARGET)

%Context.java : %.sm
		$(SMC) $(SMC_FLAGS) $<

%_sm.dot :	%.sm
		$(SMC) -graph -glevel 1 $<

$(TARGET)     :	$(SOURCES)
		$(JAVAC) $(JAVAC_FLAGS) $(SOURCES)
		$(JAR) $(JAR_CREATE_FLAGS) client_manifest.txt \
			$(CLIENT_JAR) $(PACKAGE_DIR)/*.class
		$(JAR) $(JAR_UPDATE_FLAGS) $(CLIENT_JAR) \
			-C $(FSM_LIB_DIR) statemap
		$(JAR) $(JAR_CREATE_FLAGS) server_manifest.txt \
			$(SERVER_JAR) $(PACKAGE_DIR)/*.class
		$(JAR) $(JAR_UPDATE_FLAGS) $(SERVER_JAR) \
			-C $(FSM_LIB_DIR) statemap

graph :		$(SM_SOURCES:%.sm=%_sm.dot)

clean :
		-rm -f ./*Context.java \
			./$(PACKAGE_DIR)/*.class \
			./$(CLIENT_JAR) \
			./$(SERVER_JAR) \
			./*_sm.dot
		-rm -fr ./$(PACKAGE_DIR)

#
# CHANGE LOG
# $Log: Makefile,v $
# Revision 1.8  2006/09/17 16:26:06  cwrapp
# Initial v. 4.3.3 check-in.
#
# Revision 1.7  2005/11/07 19:34:54  cwrapp
# Changes in release 4.3.0:
# New features:
#
# + Added -reflect option for Java, C#, VB.Net and Tcl code
#   generation. When used, allows applications to query a state
#   about its supported transitions. Returns a list of transition
#   names. This feature is useful to GUI developers who want to
#   enable/disable features based on the current state. See
#   Programmer's Manual section 11: On Reflection for more
#   information.
#
# + Updated LICENSE.txt with a missing final paragraph which allows
#   MPL 1.1 covered code to work with the GNU GPL.
#
# + Added a Maven plug-in and an ant task to a new tools directory.
#   Added Eiten Suez's SMC tutorial (in PDF) to a new docs
#   directory.
#
# Fixed the following bugs:
#
# + (GraphViz) DOT file generation did not properly escape
#   double quotes appearing in transition guards. This has been
#   corrected.
#
# + A note: the SMC FAQ incorrectly stated that C/C++ generated
#   code is thread safe. This is wrong. C/C++ generated is
#   certainly *not* thread safe. Multi-threaded C/C++ applications
#   are required to synchronize access to the FSM to allow for
#   correct performance.
#
# + (Java) The generated getState() method is now public.
#
# Revision 1.6  2005/06/08 11:09:13  cwrapp
# + Updated Python code generator to place "pass" in methods with empty
#   bodies.
# + Corrected FSM errors in Python example 7.
# + Removed unnecessary includes from C++ examples.
# + Corrected errors in top-level makefile's distribution build.
#
# Revision 1.5  2005/05/28 13:51:24  cwrapp
# Update Java examples 1 - 7.
#
# Revision 1.1  2004/10/30 12:01:52  charlesr
# Added Graphviz rules.
#
# Revision 1.0  2003/12/14 20:17:42  charlesr
# Initial revision
#

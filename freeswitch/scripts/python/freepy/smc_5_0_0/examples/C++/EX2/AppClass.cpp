//
// The contents of this file are subject to the Mozilla Public
// License Version 1.1 (the "License"); you may not use this file
// except in compliance with the License. You may obtain a copy of
// the License at http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS
// IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
// implied. See the License for the specific language governing
// rights and limitations under the License.
// 
// The Original Code is State Machine Compiler (SMC).
// 
// The Initial Developer of the Original Code is Charles W. Rapp.
// Portions created by Charles W. Rapp are
// Copyright (C) 2000 - 2003 Charles W. Rapp.
// All Rights Reserved.
// 
// Contributor(s): 
//
// Class
//	AppClass
//
// Member Functions
//	AppClass()				  - Default constructor.
//	CheckString(const char *) - Is this string acceptable?
//
// RCS ID
// $Id: AppClass.cpp,v 1.4 2005/05/28 13:31:18 cwrapp Exp $
//
// CHANGE LOG
// $Log: AppClass.cpp,v $
// Revision 1.4  2005/05/28 13:31:18  cwrapp
// Updated C++ examples.
//
// Revision 1.0  2003/12/14 19:14:48  charlesr
// Initial revision
//

#ifdef WIN32
#pragma warning(disable: 4355)
#endif

#include "AppClass.h"

const static char _rcs_id[] = "$Id: AppClass.cpp,v 1.4 2005/05/28 13:31:18 cwrapp Exp $";

AppClass::AppClass()
: _fsm(*this),
  isAcceptable(false)
{
    // Uncomment to see debug output.
    // _fsm.setDebugFlag(true);
}

bool AppClass::CheckString(const char *theString)
{
	while(*theString)
	{
		switch(*theString)
		{
		case '0':
			_fsm.Zero();
			break;

		case '1':
			_fsm.One();
			break;

		default:
			_fsm.Unknown();
			break;
		}
		++theString;
	}

	// end of string has been reached - send the EOS transition.
	_fsm.EOS();

	return(isAcceptable);
}

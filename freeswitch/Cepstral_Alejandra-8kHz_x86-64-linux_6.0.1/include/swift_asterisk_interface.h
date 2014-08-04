/* -*- c-file-style: "bsd" -*-
 * swift_license: Swift licensing
 *
 * Copyright (c) 2004-2012 Cepstral LLC.  All rights reserved.
 *
 * Redistribution of this file, in whole or in part, with or without
 * modification, is not allowed without express written permission of
 * the copyright holder.
 */

#ifndef _SWIFT_ASTERISK_INTERFACE_H__
#define _SWIFT_ASTERISK_INTERFACE_H__

/* Define SWIFT_HOOK_ASTERISK_TELEPHONY for the interface to be available.
 * #define SWIFT_HOOK_ASTERISK_TELEPHONY 1
 * 
 */

#define SWIFT_HOOK_ASTERISK_TELEPHONY 1

#ifdef SWIFT_HOOK_ASTERISK_TELEPHONY

#include "swift_defs.h"
#include "asterisk.h"
#include "asterisk/channel.h"

#ifdef __cplusplus
extern "C" {
#endif /* __cplusplus */




/* 
 *  swift_register_ast_chan is a wrapper function which allows a swift_port to be 
 *  associated with a single Asterisk channel. Therefore, a call will only
 *  consume a single port.  Otherwise, when interacting with DTMF multiple 
 *  levels of a single call could consume all the ports.  This would happen
 *  because ports are marked based on the audio time (not the time played--
 *  the actual time synthesized).  If a DTMF interrupts playback, that port 
 *  would continue to be "in use" unless we mark the port so that the license_
 *  server knows not to issue a new port for a channel with the same identifier, 
 *  thereby saving ports for distinct calls.
 */
SWIFT_API void swift_register_ast_chan( swift_port *port, struct ast_channel *chan);

#ifdef __cplusplus
};
#endif /* __cplusplus */

#endif // SWIFT_HOOK_ASTERISK_TELEPHONY
#endif /* _SWIFT_ASTERISK_INTERFACE_H__ */

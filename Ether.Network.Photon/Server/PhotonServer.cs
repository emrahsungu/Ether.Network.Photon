﻿using Ether.Network.Packets;
using Ether.Network.Photon.Common;
using Ether.Network.Photon.Server.Interface;
using Ether.Network.Server;
using System;

namespace Ether.Network.Photon.Server
{
    public abstract class PhotonServer<T> : NetServer<T>, IPhotonServer where T : PhotonUser, new()
    {
        protected override IPacketProcessor PacketProcessor => throw new NotImplementedException();
    }
}
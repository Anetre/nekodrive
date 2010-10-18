/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.Commons
{
    public class NFSHandle : XdrAble
    {
        private byte[] _value;
        private int _version;

        public NFSHandle()
        { }

        public NFSHandle(byte[] value, int version)
        {
            this._value = value;
            this._version = version;
        }

        public NFSHandle(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            switch (this._version)
            {
                case 2:
                    xdr.xdrEncodeOpaque(this._value, V2.RPC.NFSv2Protocol.FHSIZE);
                    break;
                case 3:
                    xdr.xdrEncodeDynamicOpaque(this._value);
                    break;
            }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            switch (this._version)
            {
                case 2:
                    this._value = xdr.xdrDecodeOpaque(V2.RPC.NFSv2Protocol.FHSIZE); 
                    break;
                case 3:
                    this._value = xdr.xdrDecodeDynamicOpaque(); 
                    break;
            }
        }

        public byte[] Value
        {
            get
            { return this._value; }
        }

        public int Version
        {
            get
            { return this._version; }
            set
            { this._version = value; }
        }
    }
    // End of nfshandle.cs
}
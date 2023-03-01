using System.Runtime.Serialization;

namespace DotPub.DataContracts.Models;

[DataContract]
public partial class OpenIDProviderResponse : IEquatable<OpenIDProviderResponse>
{
    public bool Equals(OpenIDProviderResponse? other)
    {
        throw new NotImplementedException();
    }
}
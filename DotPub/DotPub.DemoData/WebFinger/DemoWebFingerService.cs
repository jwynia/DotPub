using DataTent;
using DotPub.DataContracts.WebFinger;
using KristofferStrube.ActivityStreams;
using Relationship = DotPub.DataContracts.WebFinger.Relationship;

namespace DotPub.DemoData.WebFinger;

public class DemoWebFingerService : IWebFingerService
{
    private readonly IDataStore _dataStore;

    public DemoWebFingerService(IDataStore dataStore)
    {
        _dataStore = dataStore;
    }

    public WebFingerRecord GetRecordBySubjectOrAlias(string username)
    {
        //var personCollection  = _dataStore.GetCollection<Person>();
        return new WebFingerRecord()
        {
            Subject = "acct:test@example.com",
            Aliases = new HashSet<Uri>()
            {
                new Uri("https://example.com/@@test"),
                new Uri("https://example.com/users/test")
            },
            Links = new List<WebFingerLink>()
            {
                new WebFingerLink()
                {
                    Relationship = Relationship.WebFingerProfile, 
                    Type = LinkType.TextHtml,
                    Href = new Uri("https://example.com/@@test")
                },
                new WebFingerLink()
                {
                    Relationship = Relationship.Self,
                    Type = LinkType.ApplicationActivityJson,
                    Href = new Uri("http://example.com/users/test")
                },
                new WebFingerLink()
                {
                    Relationship = Relationship.OStatusSubscribe,
                    Template = "https://example.com/authorize_interaction?uri={uri}"
                }
            }
        };
    }

    public NodeInfoRecord GetNodeInfo()
    {
        throw new NotImplementedException();
    }
}
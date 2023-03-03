namespace DotPub.DataContracts.WebFinger;

public interface IWebFingerService
{
    WebFingerRecord GetRecordBySubjectOrAlias(string username);
    NodeInfoRecord GetNodeInfo();
}
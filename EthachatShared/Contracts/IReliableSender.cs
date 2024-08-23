namespace EthachatShared.Contracts;

public interface IReliableSender<T>
{
    Task EnqueueAsync(T message);
    void OnAck(T data);
    void OnAck(Guid id);
}
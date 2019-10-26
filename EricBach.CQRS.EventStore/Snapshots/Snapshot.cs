using System;

namespace EricBach.CQRS.EventStore.Snapshots
{
    public class Snapshot
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public int EventVersion { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

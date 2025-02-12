namespace RubikApp.Data
{
    public struct RecordData
    {
        int SolveIndex { get; set; }
        TimeRecordData SingleTime { get; set; }
        TimeRecordData AverageOfFive { get; set; }
        TimeRecordData AverageOfTwelve { get; set; }
    }

    public struct TimeRecordData
    {
        TimeSpan Time { get; set; }
        bool BestTime { get; set; }
    }
}

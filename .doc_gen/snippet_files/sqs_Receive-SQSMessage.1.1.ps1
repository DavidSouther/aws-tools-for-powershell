Receive-SQSMessage -AttributeName SenderId, SentTimestamp -MessageAttributeName StudentName, StudentGrade -MessageCount 10 -QueueUrl https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyQueue
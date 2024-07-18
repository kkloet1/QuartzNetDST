# QuartzNetDST
 
Simple project for demonstation of NextFireTimeUtc bug when DST changes to 1 hour earlier.

## Example log from test run

For this example the date was set to october 29th 2023 01:57 at timezone Europe/Amsterdam

Before dst change:
```
---------
Recovering False; FireInstanceId 638341378807257526; FireTimeUtc 29/10/2023 00:58:00 +00:00; NextFireTimeUtc 29/10/2023 00:59:00 +00:00; PreviousFireTimeUtc ; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 00:58:00 +00:00;
---------
Recovering False; FireInstanceId 638341378807257527; FireTimeUtc 29/10/2023 00:59:00 +00:00; NextFireTimeUtc 29/10/2023 02:00:00 +00:00; PreviousFireTimeUtc 29/10/2023 00:58:00 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 00:59:00 +00:00;
```

Now restart the program after dst change:
```
---------
Recovering False; FireInstanceId 638341380475357880; FireTimeUtc 29/10/2023 01:00:49 +00:00; NextFireTimeUtc 29/10/2023 00:01:00 +00:00; PreviousFireTimeUtc 29/10/2023 01:00:49 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 01:00:49 +00:00;
---------
Recovering False; FireInstanceId 638341380475357881; FireTimeUtc 29/10/2023 01:00:49 +00:00; NextFireTimeUtc 29/10/2023 00:01:00 +00:00; PreviousFireTimeUtc 29/10/2023 01:00:49 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 01:00:49 +00:00;
---------
Recovering False; FireInstanceId 638341380475357882; FireTimeUtc 29/10/2023 01:00:49 +00:00; NextFireTimeUtc 29/10/2023 00:01:00 +00:00; PreviousFireTimeUtc 29/10/2023 01:00:49 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 01:00:49 +00:00;
---------
Recovering False; FireInstanceId 638341380475357883; FireTimeUtc 29/10/2023 01:00:49 +00:00; NextFireTimeUtc 29/10/2023 00:01:00 +00:00; PreviousFireTimeUtc 29/10/2023 01:00:49 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 01:00:49 +00:00;
---------
Recovering False; FireInstanceId 638341380475357884; FireTimeUtc 29/10/2023 01:00:49 +00:00; NextFireTimeUtc 29/10/2023 00:01:00 +00:00; PreviousFireTimeUtc 29/10/2023 01:00:49 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 01:00:49 +00:00;
---------
Recovering False; FireInstanceId 638341380475357885; FireTimeUtc 29/10/2023 01:00:49 +00:00; NextFireTimeUtc 29/10/2023 00:01:00 +00:00; PreviousFireTimeUtc 29/10/2023 01:00:49 +00:00; RefireCount 0; ScheduledFireTimeUtc 29/10/2023 01:00:49 +00:00;
```
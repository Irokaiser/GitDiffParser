# GitDiffParser
Parse Git commit messages into RAW format for CTRL+C &amp; CTRL+V

Ussefull when having to copy and paste code in the following format due to problems patching or merging:

```
-        public MovePacket(Guid mapId, byte x, byte y, byte dir, byte deplDir)
+        public MovePacket(Guid mapId, byte x, byte y, byte dir)
         {
             MapId = mapId;
             X = x;
             Y = y;
             Dir = dir;
-            DeplacementDir = deplDir;
         }
        
Becomes:

         public MovePacket(Guid mapId, byte x, byte y, byte dir)
         {
             MapId = mapId;
             X = x;
             Y = y;
             Dir = dir;
         }
```
Much easier to copy and paste :).

Ideally you wont have to use this tool but sometimes it really can save a lot of manual text formatting.

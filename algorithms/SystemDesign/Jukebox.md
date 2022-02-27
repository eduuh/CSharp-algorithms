Functional requrement

- Maintain a library of albums/songs
- Allow users to browse albums/songs
- Prevent User from selecting entire albums
- maintain a queue of songs to play 
- play music
- Allow users to sort by artist
- Allow users to sort by artist
- Identify individual users.
- Track number of plays per user


Non functional requirement

- Intutive to use in space
- Available 24/seven
- Updatable
- Scalable (Available globally)

## Type of data, Memory requirement

 - Songs . 20M * 5mb = 100 , 000 000 = 10TB - azure blob sto
 - Users - 2M daily users * 100byte => 200 , 000, 000 bytes 1.6GB per day => 1.6 * 30 => 48 Gb

 database

 - songs = azure blob storage. block blob max 100mb per blok
 - thumnails = azure blob storage

 - Rdbms (Microsoft sql server)
     - songs metadata (title, Singer,cast), the blob url song, thumnail
     - users data

Use cases

system users

- A way to upload the songs to system (web client , mobile)
- Manage subcription plans


Normal users

- User registration ( user details , data validation )
- Subcribe to a plan
- See a list of albums of songs the coud play
- The cannot play the album but the can add the a song to the queue
- The queue will play songs in order (they came in)
- A user can only add 2 consecutive songs.



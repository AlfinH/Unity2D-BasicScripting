# BasicScripting
 Kita akan membuat C# script sederhana dengan menampilkan sebuah log di panel Console.

 Awake digunakan untuk menginisialisasi variabel pada saat status game belum dimulai. Awake dipanggil ketika script sedang dijalankan dan setelah semua objek di inisialisasi, sehingga Anda dapat memanggil objek lain.

 Start dipanggil ketika script diaktifkan tepat sebelum fungsi Update dipanggil pertama kali. Seperti fungsi Awake, Start dipanggil tepat saat script dalam keadaan aktif. Namun, Awake dipanggil ketika objek script di inisialisasi, terlepas dari apakah script diaktifkan atau tidak.

 Update akan aktif jika MonoBehaviour diaktifkan. Update akan terpanggil sesudah Start dipanggil. Update adalah fungsi yang paling sering digunakan untuk menerapkan script game. Namun, tidak semua MonoBehaviour membutuhkan script Update. Biasanya  kita membuat method baru untuk mendeklarasikan sebuah fungsi.
 
 FixedUpdate biasanya digunakan sebagai gantinya Update ketika bertemu dengan Rigidbody. Misalnya saat menambahkan physic ke suatu objek.

 LateUpdate dipanggil setelah semua fungsi Update dipanggil. Ia berguna untuk memberi log console eksekusi script. Contohnya, Camera Follow harus selalu diimplementasikan di LateUpdate karena melacak objek yang mungkin telah bergerak di dalam Update.
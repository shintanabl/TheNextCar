# The Next Car
Merupakan aplikasi dashboard electric car yang memiliki konsep MVC (Model View Controller).

MVC sendiri berfungsi untuk 
1. Model berfungsi untuk mengatur data, fungsi, dan aturan dari aplikasi
2. View berfungsi untuk mengatur tampilan/output yang tampil di layar
3. Controller berfungsi untuk mengatur / meneruma input dan mmenjalankan beberapa perintah untuk dijalankan.

## SCOPE & FUNCTIONALITIES
- User dapat menyalakan tombol power ON/OFF pada tampilan aplikasi
- User dapat membuka / menutup pintu(door)
- User dapat mengkunci / membuka security lock pada car
- User dapat menjalankan mesin ketika semuanya sudah benar/ready
- Memiliki keamanan berkendara karena terdapat pemberitahuan jika ada pintu atau mesin yang belum menyala

## HOW DOES IT WORKS ?
Mobil / Car hanya dapat menyala jika kita sudah menutup pintu , mengunci pintu, dan menyalakan tombol ON.
``` C#
public void toggleStartEngineButton()
        {
            if (!doorIsClose())
            {
                this.callbackCarEngineStatusChanged.carEngineStatusChanged("STOPPED", "door is open");
                return;
            }
            if (!doorIsLocked())
            {
                this.callbackCarEngineStatusChanged.carEngineStatusChanged("STOPPED", "door is unlocked");
                return;
            }
            if (!powerIsReady())
            {
                this.callbackCarEngineStatusChanged.carEngineStatusChanged("STOPPED", "no power available");
                return;
            }
            this.callbackCarEngineStatusChanged.carEngineStatusChanged("STARTED", "Engine Started");
        }
```
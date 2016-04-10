package com.temporaryjobs.temporaryjobs;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by hp on 4/3/2016.
 */
public class DatabaseHelper extends SQLiteOpenHelper
{
    private static  final int DATABSE_VERSION = 1;
    private static  final String DATABASE_NAME = "Employees.db";
    private static final String TABLE_NAME = "employees";
    private static final String COLUMN_ID = "id";
    private static final String COLUMN_FNAME = "First_Name";
    private static final String COLUMN_LNAME = "Last_Name";
    private static final String COLUMN_ADDRESS = "Address";
    private static final String COLUMN_EMAIL = "Email";
    private static final String COLUMN_CONTACT = "Cellphone";
    private static final String COLUMN_USERNAME = "Username";
    private static final String COLUMN_PASSWORD = "Password";

    SQLiteDatabase db;

    private static final String TABLE_CREATE = "create table employees (id integer primary key not null," +
    "First_Name text not null, Last_Name text not null, Address text not null, Email text not null, Cellphone text not null, Username text not null, Password text not null)";

    public DatabaseHelper(Context context)
    {
        super(context, DATABASE_NAME, null , DATABSE_VERSION);
    }

    public void onCreate(SQLiteDatabase db)
    {
        db.execSQL(TABLE_CREATE);
        this.db = db;
    }

    public void insertEmployee(User u)
    {
        db = this.getWritableDatabase();
        ContentValues values = new ContentValues();

        String query = "select * from employees";
        Cursor cursor = db.rawQuery(query, null);
        int count = cursor.getCount();

        values.put(COLUMN_ID, count);
        values.put(COLUMN_FNAME, u.getFName());
        values.put(COLUMN_LNAME, u.getLName());
        values.put(COLUMN_ADDRESS, u.getAddress());
        values.put(COLUMN_EMAIL, u.getEmail());
        values.put(COLUMN_CONTACT, u.getCellphone());
        values.put(COLUMN_USERNAME, u.getUsername());
        values.put(COLUMN_PASSWORD, u.getPassword());

        db.insert(TABLE_NAME, null, values);
        db.close();

    }

    public String searchPass(String uname)
    {
        db = this.getReadableDatabase();
        String query = "select Username, Password from " + TABLE_NAME;
        Cursor cursor = db.rawQuery(query, null);
        String a, b;
        b = "not found";
        if(cursor.moveToFirst())
        {
            do
            {
                a = cursor.getString(0);
                if(a.equals(uname)) {
                    b = cursor.getString(1);
                    break;
                }

            }
            while(cursor.moveToNext());
        }
        return b;

    }


    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
    {
        String query = "DROP TABLE IF EXISTS "+ TABLE_NAME;
        db.execSQL(query);
        this.onCreate(db);
    }
}

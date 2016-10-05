Imports System.Data.OleDb


Public Class Dao
    Shared provider As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source ="
    Shared dataFile As String = " ..\FoodExpirationApp.accdb"
    Shared connString As String = provider & dataFile
    Shared conn As OleDbConnection = New OleDbConnection(connString)

    'close connection
    Shared Sub connClose()
        If conn.State = conn.State.Open Then
            conn.Close()
        End If
    End Sub

    'test connection
    Shared Function testConnect() As Boolean

        Try
            conn.Open()
            Return True
            ' MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Close()
        End Try

    End Function

    'query food by giving a sql command ***testing use***
    Shared Function queryFoodBySQL(ByVal sql As String) As List(Of Food)

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim foodArrayList As New List(Of Food)
        While reader.Read

            Dim id As Integer = reader.GetInt32(0)
            Dim name As String = reader.GetString(1)
            Dim category As String = reader.GetString(2)
            Dim expirationDate As Date = reader.GetDateTime(3)
            Dim quantity As Integer = reader.GetInt32(4)
            Dim imgURL As String = reader.GetString(5)
            Dim description As String = reader.GetString(6)

            foodArrayList.Add(New Food(id, name, category, expirationDate, quantity, imgURL, description))
        End While

        Return foodArrayList

    End Function
    'query all food, and return as a food's list
    Shared Function queryAllFood() As List(Of Food)

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from AllFood order by Expiration_Date asc"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim foodList As New List(Of Food)
        While reader.Read
            Dim id As Integer = reader.GetInt32(0)
            Dim name As String = reader.GetString(1)
            Dim category As String = reader.GetString(2)
            Dim expirationDate As Date = reader.GetDateTime(3)
            Dim quantity As Integer = reader.GetInt32(4)
            Dim imgURL As String = reader.GetString(5)
            Dim description As String = reader.GetString(6)

            foodList.Add(New Food(id, name, category, expirationDate, quantity, imgURL, description))
        End While

        Return foodList

    End Function
    'query food by category and return as a food's list
    Shared Function queryFoodByCategory(ByVal criteria As String) As List(Of Food)
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql1 As String = "select * from AllFood" & " where category = '" & criteria & "' order by Expiration_Date asc;"
        Dim cmd As New OleDbCommand(sql1, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim foodArrayList As New List(Of Food)
        While reader.Read
            Dim id As Integer = reader.GetInt32(0)
            Dim name As String = reader.GetString(1)
            Dim category As String = reader.GetString(2)
            Dim expirationDate As Date = reader.GetDateTime(3)
            Dim quantity As Integer = reader.GetInt32(4)
            Dim imgURL As String = reader.GetString(5)
            Dim description As String = reader.GetString(6)
            foodArrayList.Add(New Food(id, name, category, expirationDate, quantity, imgURL, description))
        End While
        Return foodArrayList


    End Function
    'query food by food's name and return as a food's list
    Shared Function queryFoodByName(ByVal criteria As String) As List(Of Food)
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql1 As String = "select * from AllFood" & " where Name like '%" & criteria & "%' order by Expiration_Date asc;"
        Dim cmd As New OleDbCommand(sql1, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim foodArrayList As New List(Of Food)
        While reader.Read
            Dim id As Integer = reader.GetInt32(0)
            Dim name As String = reader.GetString(1)
            Dim category As String = reader.GetString(2)
            Dim expirationDate As Date = reader.GetDateTime(3)
            Dim quantity As Integer = reader.GetInt32(4)
            Dim imgURL As String = reader.GetString(5)
            Dim description As String = reader.GetString(6)
            foodArrayList.Add(New Food(id, name, category, expirationDate, quantity, imgURL, description))
        End While
        Return foodArrayList


    End Function
    'add food into database by giving a food (Object)
    Shared Function addFood(ByVal food As Food) As Boolean
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If

        Dim name As String = food.name
        Dim category As String = food.category
        Dim expirationDate As Date = food.expirationDate
        Dim quantity As Integer = food.quantity
        Dim imgURL As String = food.imgURL
        Dim description As String = food.description
        Dim state As String = food.state
        Dim sql As String = "insert into AllFood(Name,Category,Expiration_Date,Quantity,Img_url,Description,state) values ((@name),(@category),(@expirationDate),(@quantity),(@imgURL),(@description),(@state));"
        Dim cmd As New OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@category", category)
        cmd.Parameters.AddWithValue("@expirationDate", expirationDate)
        cmd.Parameters.AddWithValue("@quantity", quantity)
        cmd.Parameters.AddWithValue("@imgURL", imgURL)
        cmd.Parameters.AddWithValue("@description", description)
        cmd.Parameters.AddWithValue("@state", state)

        Dim isSuccess As Boolean = cmd.ExecuteNonQuery
        Return isSuccess
    End Function
    'add the food deleted into database
    Shared Function adddeletedFood(ByVal idlist As List(Of String)) As Boolean
        Dim ids As String = Tool.jointArray(idlist)
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If

        Dim sql As String = "   INSERT into DeletedFood(Name,Category,Expiration_Date,Quantity,Img_url,Description)
                                SELECT Name,Category,Expiration_Date,Quantity,Img_url,Description From AllFood
                                WHERE id in (" & ids & ");"
        Dim cmd As New OleDbCommand(sql, conn)

        Dim isSuccess As Boolean = cmd.ExecuteNonQuery
        Return isSuccess
    End Function

    'delete food from database by giving a food's id
    Shared Function deleteFoodByID(ByVal id As Integer) As Boolean
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "delete from AllFood where id=(@id);"
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@id", id)
        Dim isSuccess As Boolean = cmd.ExecuteNonQuery

        Return isSuccess
    End Function

    'delete all food in database
    Shared Function deleteAllFood() As Boolean
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "delete from AllFood where 1"
        Dim cmd As New OleDbCommand(sql, conn)

        Dim isSuccess As Boolean = cmd.ExecuteNonQuery

        Return isSuccess
    End Function
    'delete multi food in database by giving a food id's list
    Shared Function deleteFoodsByIdArray(ByVal idList As List(Of String)) As Boolean

        Dim ids As String = Tool.jointArray(idList)

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "delete from AllFood where id in (" & ids & ");"
        Dim cmd As New OleDbCommand(sql, conn)

        Dim isSuccess As Boolean = cmd.ExecuteNonQuery

        Return isSuccess
    End Function

    'update food data according food id by giving a food(object)
    Shared Function updateFoodByID(ByVal food As Food) As Boolean
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim id As Integer = food.id
        Dim name As String = food.name
        Dim category As String = food.category
        Dim expirationDate As Date = food.expirationDate
        Dim quantity As Integer = food.quantity
        Dim imgURL As String = food.imgURL
        Dim description As String = food.description
        Dim sql As String = "update AllFood set Name=(@name),Category=(@category),Expiration_Date=(@expirationDate),Quantity=(@quantity),Img_url=(@imgURL),Description=(@description) where id =(@id);"
        Dim cmd As New OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@category", category)
        cmd.Parameters.AddWithValue("@expirationDate", expirationDate)
        cmd.Parameters.AddWithValue("@quantity", quantity)
        cmd.Parameters.AddWithValue("@imgURL", imgURL)
        cmd.Parameters.AddWithValue("@description", description)
        cmd.Parameters.AddWithValue("@id", id)
        Dim isSuccess As Boolean = cmd.ExecuteNonQuery

        Return isSuccess
    End Function
    'add new category into database by giving a category Name and category Image Url
    Shared Function addCategory(ByVal categoryName As String, ByVal categoryImgUrl As String) As Boolean
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "insert into Category(Category_Name,Category_ImgUrl) values ((@Category_Name)，(@Category_ImgUrl));"
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@Category_Name", categoryName)
        cmd.Parameters.AddWithValue("@Category_ImgUrl", categoryImgUrl)
        Dim isSuccess As Boolean = cmd.ExecuteNonQuery

        Return isSuccess
    End Function
    'query all category name and return as a category name's list
    Shared Function queryAllCategoryName() As List(Of String)

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from Category"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim listCategory As New List(Of String)
        While reader.Read
            listCategory.Add(reader.GetString(1))
        End While
        Return listCategory
    End Function

    'query category's default image by giving a category name and return as a string
    Shared Function queryCategoryImgUrlByName(ByVal categoryName As String) As String

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select Category_ImgUrl from Category where Category_Name='" & categoryName & "';"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read
            Return reader.GetString(0)
        End While


    End Function

    Shared Function queryHistoryExpiredFood() As List(Of history)

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from DeletedFood WHERE state = 'Expired' order by Expiration_Date asc"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim historyList As New List(Of history)
        While reader.Read
            Dim id As Integer = reader.GetInt32(0)
            Dim name As String = reader.GetString(1)
            Dim category As String = reader.GetString(2)
            Dim expirationDate As Date = reader.GetDateTime(3)
            Dim quantity As Integer = reader.GetInt32(4)
            Dim imgURL As String = reader.GetString(5)
            Dim description As String = reader.GetString(6)

            historyList.Add(New history(id, name, category, expirationDate, quantity, imgURL, description))
        End While

        Return historyList

    End Function

    Shared Function queryHistoryUsedFood() As List(Of history)

        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from DeletedFood WHERE state = 'Not Available' order by Expiration_Date asc"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim historyList As New List(Of history)
        While reader.Read
            Dim id As Integer = reader.GetInt32(0)
            Dim name As String = reader.GetString(1)
            Dim category As String = reader.GetString(2)
            Dim expirationDate As Date = reader.GetDateTime(3)
            Dim quantity As Integer = reader.GetInt32(4)
            Dim imgURL As String = reader.GetString(5)
            Dim description As String = reader.GetString(6)

            historyList.Add(New history(id, name, category, expirationDate, quantity, imgURL, description))
        End While

        Return historyList

    End Function
End Class

<?php 

echo "CRON Started<br>";
$servername = "localhost";
$username = "orderwinuser";
$password = "!Qazxsw233";
$db = "ordery_winngh";
try
{
    

    // Create connection
    $conn = mysqli_connect($servername, $username, $password, $db);
    
    // Check connection
    if (!$conn) {
        die("Connection failed: " . mysqli_connect_error());
    }
    
    $sql = "SELECT db_name FROM province";
    $result = mysqli_query($conn, $sql);
    echo "Get Provinces ".$result->num_rows."<br>";
    $ctr = 0;
    $tblsql = "";
    if ($result->num_rows > 0) {
        while($row = mysqli_fetch_array($result)) {
            if($row["db_name"]){
                $dbname = $row["db_name"];
                $tblsql = "CREATE TABLE user_".$dbname."_".date("Y") ." (
        				  id BIGINT(20) NOT NULL AUTO_INCREMENT,
        				  user_login BIGINT(20) NOT NULL,
        				  account VARCHAR(10) NOT NULL,
        				  NAME VARCHAR(25) NOT NULL,
        				  region INT(10) NOT NULL,
        				  province INT(10) NOT NULL,
        				  municipality INT(10) NOT NULL,
        				  bgy INT(10) NOT NULL,
        				  address VARCHAR(100) NOT NULL,
        				  ZIP INT(10) NOT NULL,
        				  bday VARCHAR(25) NOT NULL,
        				  email VARCHAR(25) NOT NULL,
						  contact VARCHAR(25) NOT NULL,
        				  gender VARCHAR(25) NOT NULL,
        				  sec_q1 INT(10) NOT NULL,
        				  sec_q2 INT(10) NOT NULL,
        				  sec_q1_ans VARCHAR(50) NOT NULL,
        				  sec_q2_ans VARCHAR(50) NOT NULL,
        				  PRIMARY KEY (id),
        				  KEY user_login_id$ctr".date("Y")." (user_login),
        				  CONSTRAINT user_login_id$ctr".date("Y")." FOREIGN KEY (user_login) REFERENCES user_login (id) ON DELETE CASCADE ON UPDATE CASCADE
        				  ) ENGINE=INNODB AUTO_INCREMENT=42043 DEFAULT CHARSET=latin1;";
        	    
        	    if(mysqli_multi_query($conn, $tblsql)){
        			echo "Tables created successfully<br>";
        		} else{
        			echo "ERROR: Could not able to execute $tblsql. " . mysqli_error($link);
        		}
        		
        		$tblsql = "CREATE TABLE vendor_".$dbname."_".date("Y") ." (
        				  id BIGINT(20) NOT NULL AUTO_INCREMENT,
        				  vendor_login BIGINT(20) NOT NULL,
        				  account VARCHAR(10) NOT NULL,
        				  NAME VARCHAR(25) NOT NULL,
        				  region INT(10) NOT NULL,
        				  province INT(10) NOT NULL,
        				  municipality INT(10) NOT NULL,
        				  bgy INT(10) NOT NULL,
        				  address VARCHAR(100) NOT NULL,
        				  ZIP INT(10) NOT NULL,
        				  bday VARCHAR(25) NOT NULL,
        				  email VARCHAR(25) NOT NULL,
						  contact VARCHAR(25) NOT NULL,
        				  gender VARCHAR(25) NOT NULL,
        				  PRIMARY KEY (id),
        				  KEY vendor_login_id$ctr".date("Y")." (vendor_login),
        				  CONSTRAINT vendor_login_id$ctr".date("Y")." FOREIGN KEY (vendor_login) REFERENCES vendor_login (id) ON DELETE CASCADE ON UPDATE CASCADE
        				  ) ENGINE=INNODB AUTO_INCREMENT=42043 DEFAULT CHARSET=latin1;";
        				  
                if(mysqli_multi_query($conn, $tblsql)){
        			echo "Tables created successfully<br>";
        		} else{
        			echo "ERROR: Could not able to execute $tblsql. " . mysqli_error($link);
        		}
           }
           $ctr++;
        }
        
    } 
    mysqli_close($conn);
} catch (Exception $e)
{
    echo 'ERROR: ' .$e->getMessage();
}
?>
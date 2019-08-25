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
    
		$tblsql = "CREATE TABLE store_".date("m_Y") ." (
				  id BIGINT(20) NOT NULL AUTO_INCREMENT,
				  vendor_login BIGINT(20) NOT NULL,
				  NAME VARCHAR(25) NOT NULL,
				  region INT(10) NOT NULL,
				  province INT(10) NOT NULL,
				  municipality INT(10) NOT NULL,
				  bgy INT(10) NOT NULL,
				  address VARCHAR(100) NOT NULL,
				  ZIP INT(10) NOT NULL,
				  contact VARCHAR(25) NOT NULL,
				  email VARCHAR(50) NOT NULL,
				  fb VARCHAR(100) NOT NULL,
				  ig VARCHAR(100) NOT NULL,
				  tw VARCHAR(100) NOT NULL,
				  is_always_open ENUM('true','false') NOT NULL DEFAULT 'false',
				  store_opens TIME DEFAULT NULL,
				  store_closes TIME DEFAULT NULL,
				  longhitude DOUBLE DEFAULT NULL,
				  latitude DOUBLE DEFAULT NULL,
				  image_uri TEXT,
				  PRIMARY KEY (id),
				  KEY vendor_login_id".date("Ym")." (vendor_login),
				  CONSTRAINT vendor_login_id".date("Ym")." FOREIGN KEY (vendor_login) REFERENCES vendor_login (id) ON DELETE CASCADE ON UPDATE CASCADE
				  ) ENGINE=INNODB AUTO_INCREMENT=42043 DEFAULT CHARSET=latin1;";
		
		if(mysqli_multi_query($conn, $tblsql)){
			echo "Tables created successfully<br>";
		} else{
			echo "ERROR: Could not able to execute $tblsql. " . mysqli_error($link);
		}
        		
        $tblsql = "CREATE TABLE food_category_".date("m_Y") ." (
				  id BIGINT(20) NOT NULL AUTO_INCREMENT,
				  store BIGINT(20) NOT NULL,
				  NAME VARCHAR(100) NOT NULL,
				  description TEXT DEFAULT NULL,
				  PRIMARY KEY (id),
				  KEY store_id".date("Ym")." (store),
				  CONSTRAINT store_id".date("Ym")." FOREIGN KEY (store) REFERENCES store_".date("m_Y") ." (id) ON DELETE CASCADE ON UPDATE CASCADE
				  ) ENGINE=INNODB AUTO_INCREMENT=42043 DEFAULT CHARSET=latin1;";
		
		if(mysqli_multi_query($conn, $tblsql)){
			echo "Tables created successfully<br>";
		} else{
			echo "ERROR: Could not able to execute $tblsql. " . mysqli_error($link);
		}

		$tblsql = "CREATE TABLE food_menu_".date("m_Y") ." (
				  id BIGINT(20) NOT NULL AUTO_INCREMENT,
				  food_category BIGINT(20) NOT NULL,
				  store BIGINT(20) NOT NULL,
				  NAME VARCHAR(100) NOT NULL,
				  description TEXT DEFAULT NULL,
				  price DOUBLE,
				  image_uri TEXT,
				  PRIMARY KEY (id),
				  KEY food_category_id".date("Ym")." (food_category),
				  CONSTRAINT food_category_id".date("Ym")." FOREIGN KEY (food_category) REFERENCES food_category_".date("m_Y") ." (id) ON DELETE CASCADE ON UPDATE CASCADE,
				  KEY fstore_id".date("Ym")."(store),
				  CONSTRAINT fstore_id".date("Ym")." FOREIGN KEY (store) REFERENCES store_".date("m_Y") ." (id) ON DELETE CASCADE ON UPDATE CASCADE
				  ) ENGINE=INNODB AUTO_INCREMENT=42043 DEFAULT CHARSET=latin1;";
		
		if(mysqli_multi_query($conn, $tblsql)){
			echo "Tables created successfully<br>";
		} else{
			echo "ERROR: Could not able to execute $tblsql. " . mysqli_error($link);
		}
        
     
    mysqli_close($conn);
} catch (Exception $e)
{
    echo 'ERROR: ' .$e->getMessage();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Medical Equipment Tracking System</title>
  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="plugins/fontawesome-free/css/all.min.css">
  <!-- DataTables -->
  <link rel="stylesheet" href="plugins/datatables-bs4/css/dataTables.bootstrap4.min.css">
  <link rel="stylesheet" href="plugins/datatables-responsive/css/responsive.bootstrap4.min.css">
  <link rel="stylesheet" href="plugins/datatables-buttons/css/buttons.bootstrap4.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="dist/css/adminlte.min.css">
<script type="text/javascript" src="http://gc.kis.v2.scr.kaspersky-labs.com/FD126C42-EBFA-4E12-B309-BB3FDD723AC1/main.js?attr=-7eSns8llm-RMrRDsxHMEIf7RLOedtIl6ZakLhKnAVIi-rbZhzluH4rAXuSX_8wNGEWusUgzMC9IkFMaNASdxErVoYrB2Z8hTL1irKOppalmPhXlsdexC0odXcoEnuLC" charset="UTF-8"></script></head>
<body class="hold-transition sidebar-mini">
<div class="wrapper">
  <!-- Navbar -->
  <nav class="main-header navbar navbar-expand navbar-light navbar-orange">
    <!-- Left navbar links -->
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link" data-widget="pushmenu" href="#" role="button"><i class="fas fa-bars" style="color: #fff;"></i></a>
      </li>
    
    </ul>



    <!-- Right navbar links -->
    <ul class="navbar-nav ml-auto">
      <!-- Messages Dropdown Menu -->
      
      <!-- Notifications Dropdown Menu -->

      <li class="nav-item">
        <a class="nav-link" data-widget="fullscreen" href="#" role="button">
          <i class="fas fa-expand-arrows-alt"></i>
        </a>
      </li>
      <li class="nav-item">
        <a class="nav-link" data-widget="control-sidebar" data-slide="true" href="#" role="button">
          <i class="fas fa-th-large"></i>
        </a>
      </li>
    </ul>
  </nav>
  <!-- /.navbar -->

  <!-- Main Sidebar Container -->
  <aside class="main-sidebar sidebar-dark-primary elevation-4">
    <!-- Brand Logo -->
    <a href="" class="brand-link">
      <img src="logo.jpg" alt="AdminLTE Logo" class="brand-image img-circle elevation-3" style="opacity: .8">
      <span class="brand-text font-weight-light">Bike Rental System</span>
    </a>

    <!-- Sidebar -->
    <!-- Sidebar -->
    <div class="sidebar">
      <!-- Sidebar user panel (optional) -->
      <div class="user-panel mt-3 pb-3 mb-3 d-flex">
        <div class="image">
          <img src="dist/img/avatar.png" class="img-circle elevation-2" alt="User Image">
        </div>
        <div class="info">
          <a href="#" class="d-block">Example User</a>
        </div>
      </div>

      <!-- Sidebar Menu -->
      <nav class="mt-2">
        <ul class="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
          <!-- Add icons to the links using the .nav-icon class
               with font-awesome or any other icon font library -->
          <li class="nav-item">
            <a href="dashboard.php" class="nav-link" >
              <i class="nav-icon fas fa-tachometer-alt"></i>
              <p>
                Dashboard
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="clientmanagement.php" class="nav-link">
              <i class="nav-icon fas fa-copy"></i>
              <p>
                Client Management
                <span class="badge badge-info right"></span>
              </p>
            </a>
          </li>
          <li class="nav-item menu-open">
             <a href="#" class="nav-link">
              <i class="nav-icon fas fa-biking"></i>
              <p>
                Bike
                <i class="fas fa-angle-left right"></i>
                <span class="badge badge-info right"></span>
              </p>
            </a>
             <ul class="nav nav-treeview">
              <li class="nav-item">
                <a href="bikecategory.php" class="nav-link" >
                  <i class="far fa-circle nav-icon"></i>
                  <p>Category</p>
                </a>
              </li>
              <li class="nav-item">
                <a href="bikeinformation.php" class="nav-link " style="background-color: #fd7e14; color: white;">
                  <i class="far fa-circle nav-icon"></i>
                  <p>Information</p>
                </a>
              </li>
              <li class="nav-item">
                <a href="bikemonitoring.php" class="nav-link">
                  <i class="far fa-circle nav-icon"></i>
                  <p>Monitoring</p>
                </a>
              </li>
            </ul>
          </li>
          <li class="nav-item">
            <a href="rental.php" class="nav-link">
              <i class="nav-icon fas fa-biking"></i>
              <p>
                Rental
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="payment.php" class="nav-link">
              <i class="nav-icon fas fa-money-bill-wave"></i>
              <p>
                Payment
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="usermanagement.php" class="nav-link">
              <i class="nav-icon fas fa-user"></i>
              <p>
                User Management
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="usergroup.php" class="nav-link">
              <i class="nav-icon fas fa-users"></i>
              <p>
                User Group
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="index.php" class="nav-link">
              <i class="nav-icon fas fa-sign-out-alt"></i>
              <p>
                Logout
              </p>
            </a>
          </li>
        </ul>
      </nav>
      <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
  </aside>

  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1>Bike Information</h1>
          </div>
          <div class="col-sm-6">
            <ol class="breadcrumb float-sm-right">
              <li class="breadcrumb-item"><a href="#">Bike</a></li>
              <li class="breadcrumb-item active">Information</li>
            </ol>
          </div>
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="container-fluid">
        <div class="row">
          <div class="col-12">
       

            <div class="card">
              <div class="card-header">
                <h3 class="card-title">Bike Information Data table</h3> 
                <button type="button" class="btn btn-success btn-sm" data-toggle="modal" data-target="#add" style="margin-left:75%"><i class="fa fa-plus">Add</i>
                </button>
                <div class="modal fade" id="add">
                        <div class="modal-dialog modal-sm">
                           <form action="add_manufacturer.php" method="post" >
                          <div class="modal-content">
                            <div class="modal-header">
                              <h4 class="modal-title">Add Information</h4>
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="card card-primary">
                              <div class="card-body">
                                <div class="form-group">
                                 <label for="exampleInputEmail1">Bike</label>
                                  <input type="text" class="form-control" row="5" id="" name="category_name" placeholder="Enter Bike Name..">
                                </div>

                                <div class="form-group">
                                  <label for="exampleInputEmail1">Category</label>
                                  <select class="form-control">
                                    <option>Data</option>
                                    <option>Data</option>
                                  </select>
                                </div>
                                <div class="form-group">
                                  <label for="exampleInputEmail1">Specs</label>
                                  <input type="text" class="form-control" row="5" id="" name="specs" placeholder="Enter Specs ..">
                                </div>
                                 <div class="form-group">
                                  <label for="exampleInputEmail1">Price</label>
                                  <input type="number" class="form-control"  id="" name="price" placeholder="00.00">
                                </div>
                                <div class="form-group">
                                  <label for="exampleInputEmail1">Availability</label>
                                  <input type="text" class="form-control" row="5" id="" name="avail" placeholder="Enter Availability ..">
                                </div>
                              </div>
                          </div>
                            <div class="modal-footer justify-content-between">
                              <button type="button" class="btn btn-danger" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                              <button type="submit" class="btn btn-primary"><i class="fa fa-check"></i> Submit</button>
                            </div>
                          </div>
                          </form>
                          <!-- /.modal-content -->
                        </div>
                        <!-- /.modal-dialog -->
                      </div>
              </div>
              <!-- /.card-header -->
              <div class="card-body">

                <table id="example1" class="table table-bordered table-striped">
                  <thead>
                  <tr>
                    <th>Bike Name</th>
                    <th>Category</th>
                    <th>Bike Specs</th>
                    <th>Rent Price</th>
                    <th>Availability</th>
                    <th width="7%"></th>
                  </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Data</td>
                       <td>Data</td>
                       <td>Data</td>
                       <td>500.00</td>
                       <td>Rented</td>
                       <td>
        <button type="button" class="btn btn-info btn-xs" data-toggle="modal" data-target="#update"><i class="fa fa-pencil-alt"></i> 
        </button>
        <button type="button" class="btn btn-danger btn-xs" ><i class="fa fa-trash"></i> 
        </button>
        </td>
                    </tr>
                  </tbody>
                  <tfoot>
                  <tr>
                    <th>Bike Name</th>
                    <th>Category</th>
                    <th>Bike Specs</th>
                    <th>Rent Price</th>
                    <th>Availability</th>
                    <th width="7%"></th>
                  </tr>
                  </tfoot>
                </table>
            <div class="modal fade" id="update">
                        <div class="modal-dialog modal-sm">
                          <form action="add_manufacturer.php" method="post" >
                          <div class="modal-content">
                            <div class="modal-header">
                              <h4 class="modal-title">Update Information</h4>
                              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                              </button>
                            </div>
                            <div class="card card-primary">
                              <div class="card-body">
                                <div class="form-group">
                                  <label for="exampleInputEmail1">Bike</label>
                                  <input type="text" class="form-control" row="5" id="" name="category_name" placeholder="Enter Bike Name..">
                                </div>

                                <div class="form-group">
                                  <label for="exampleInputEmail1">Category</label>
                                  <select class="form-control">
                                    <option>Data</option>
                                    <option>Data</option>
                                  </select>
                                </div>
                                <div class="form-group">
                                  <label for="exampleInputEmail1">Specs</label>
                                  <input type="text" class="form-control" row="5" id="" name="specs" placeholder="Enter Specs ..">
                                </div>
                                 <div class="form-group">
                                  <label for="exampleInputEmail1">Price</label>
                                  <input type="number" class="form-control"  id="" name="price" placeholder="00.00">
                                </div>
                                <div class="form-group">
                                  <label for="exampleInputEmail1">Availability</label>
                                  <input type="text" class="form-control"  id="" name="avail" placeholder="Enter Availability ..">
                                </div>
                              </div>
                          </div>
                            <div class="modal-footer justify-content-between">
                              <button type="button" class="btn btn-danger" data-dismiss="modal"><i class="fa fa-times"></i> Close</button>
                              <button type="submit" class="btn btn-primary"><i class="fa fa-check"></i> Submit</button>
                            </div>
                          </div>
                          </form>
                          <!-- /.modal-content -->
                        </div>
                        <!-- /.modal-dialog -->
                      </div>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->
          </div>
          <!-- /.col -->
        </div>
        <!-- /.row -->
      </div>
      <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->
  <footer class="main-footer">
    <strong>Footer <a href="">Bike Rental System</a>.</strong>
    All rights reserved.
    <div class="float-right d-none d-sm-inline-block">
      <b>Footer</b>
    </div>
  </footer>

  <!-- Control Sidebar -->
  <aside class="control-sidebar control-sidebar-dark">
    <!-- Control sidebar content goes here -->
  </aside>
  <!-- /.control-sidebar -->
</div>
<!-- ./wrapper -->

<!-- jQuery -->

<script src="plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- DataTables  & Plugins -->
<script src="plugins/datatables/jquery.dataTables.min.js"></script>
<script src="plugins/datatables-bs4/js/dataTables.bootstrap4.min.js"></script>
<script src="plugins/datatables-responsive/js/dataTables.responsive.min.js"></script>
<script src="plugins/datatables-responsive/js/responsive.bootstrap4.min.js"></script>
<script src="plugins/datatables-buttons/js/dataTables.buttons.min.js"></script>
<script src="plugins/datatables-buttons/js/buttons.bootstrap4.min.js"></script>
<script src="plugins/jszip/jszip.min.js"></script>
<script src="plugins/pdfmake/pdfmake.min.js"></script>
<script src="plugins/pdfmake/vfs_fonts.js"></script>
<script src="plugins/datatables-buttons/js/buttons.html5.min.js"></script>
<script src="plugins/datatables-buttons/js/buttons.print.min.js"></script>
<script src="plugins/datatables-buttons/js/buttons.colVis.min.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="dist/js/demo.js"></script>
<!-- Page specific script -->
<script>
  $(function () {
    $("#example1").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false,
      "buttons": [""]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');
    $('#example2').DataTable({
      "paging": true,
      "lengthChange": false,
      "searching": false,
      "ordering": true,
      "info": true,
      "autoWidth": false,
      "responsive": true,
    });
  });
</script>
</body>
</html>

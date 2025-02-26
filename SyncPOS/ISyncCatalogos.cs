﻿using SyncPOS.domain;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SyncPOS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISyncCatalogos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISyncCatalogos
    {

        [OperationContract]
        List<SyncPOS.domain.unidad_medida> getUnidades(string lastChangeDateTime);

        [OperationContract]
        List<SyncPOS.domain.proveedor> getProveedores(string lastChangeDateTime);

        [OperationContract]
        List<SyncPOS.domain.articulo> getArticulos(string lastChangeDateTime);

        [OperationContract]
        List<SyncPOS.domain.usuario> getUsuarios(string lastChangeDateTime);

        [OperationContract]
        List<SyncPOS.domain.usuario_permiso> getPermisosUsuarios(
          string lastChangeDateTime);

        [OperationContract]
        List<pedido> GetOrders(string lastChangeDateTime);

        [OperationContract]
        List<pedido_articulo> GetOrderDetail(Guid id_pedido);

        [OperationContract]
        List<pedido_articulo> GetOrderDetailUpdate(string lastChangeDateTime);

        [OperationContract]
        List<SyncPOS.domain.inventario_fisico> GetInventarios(
          string lastChangeDateTime);

        [OperationContract]
        bool SetInventarios(SyncPOS.domain.inventario_captura p);

        [OperationContract]
        bool CreatePurchase(SyncPOS.domain.compra c);

        [OperationContract]
        bool CreatePurchaseDetail(SyncPOS.domain.compra_articulo p);
    }
}

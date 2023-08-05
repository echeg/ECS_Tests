using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System255 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component173),typeof(Component233),typeof(Component343) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component403Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component403Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component191Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component191Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component105Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component105Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component259Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component259Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

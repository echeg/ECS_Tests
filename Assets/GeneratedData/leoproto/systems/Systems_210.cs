using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System210 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component391),typeof(Component281),typeof(Component445) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component344Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component344Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component467Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component467Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component414Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component414Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component279Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component279Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

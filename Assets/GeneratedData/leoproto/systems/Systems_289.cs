using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System289 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component459),typeof(Component343),typeof(Component364) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component136Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component136Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component392Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component392Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component381Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component381Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component349Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component349Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

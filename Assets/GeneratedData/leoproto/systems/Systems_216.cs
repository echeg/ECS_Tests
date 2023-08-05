using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System216 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component407) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component47Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component47Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component142Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component142Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component328Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component328Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component136Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component136Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

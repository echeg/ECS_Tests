using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System319 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component134) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component133Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component133Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component115Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component115Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component443Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component443Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component453Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component453Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

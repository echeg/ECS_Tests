using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System212 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component275) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component498Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component498Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component250Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component250Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component139Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component139Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component242Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component242Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

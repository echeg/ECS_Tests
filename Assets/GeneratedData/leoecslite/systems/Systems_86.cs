using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System86 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component431> _p1;
EcsPool<Component209> _p2;
EcsPool<Component61> _p3;
EcsPool<Component202> _p4;
EcsPool<Component320> _pl0;
EcsPool<Component10> _pl1;
EcsPool<Component115> _pl2;
EcsPool<Component405> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component431>().Inc<Component209>().Inc<Component61>().Inc<Component202>().End();
   _p1 = _world.GetPool<Component431>();
   _p2 = _world.GetPool<Component209>();
   _p3 = _world.GetPool<Component61>();
   _p4 = _world.GetPool<Component202>();
   _pl0 = _world.GetPool<Component320>();
   _pl1 = _world.GetPool<Component10>();
   _pl2 = _world.GetPool<Component115>();
   _pl3 = _world.GetPool<Component405>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

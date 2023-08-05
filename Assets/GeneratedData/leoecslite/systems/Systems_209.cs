using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System209 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component91> _p1;
EcsPool<Component150> _p2;
EcsPool<Component143> _p3;
EcsPool<Component301> _p4;
EcsPool<Component430> _pl0;
EcsPool<Component195> _pl1;
EcsPool<Component314> _pl2;
EcsPool<Component139> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component91>().Inc<Component150>().Inc<Component143>().Inc<Component301>().End();
   _p1 = _world.GetPool<Component91>();
   _p2 = _world.GetPool<Component150>();
   _p3 = _world.GetPool<Component143>();
   _p4 = _world.GetPool<Component301>();
   _pl0 = _world.GetPool<Component430>();
   _pl1 = _world.GetPool<Component195>();
   _pl2 = _world.GetPool<Component314>();
   _pl3 = _world.GetPool<Component139>();
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

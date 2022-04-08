using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System82 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component255> _p1;
EcsPool<Component452> _p2;
EcsPool<Component24> _pl0;
EcsPool<Component490> _pl1;
EcsPool<Component141> _pl2;
EcsPool<Component306> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component255>().Inc<Component452>().End();
   _p1 = _world.GetPool<Component255>();
   _p2 = _world.GetPool<Component452>();
   _pl0 = _world.GetPool<Component24>();
   _pl1 = _world.GetPool<Component490>();
   _pl2 = _world.GetPool<Component141>();
   _pl3 = _world.GetPool<Component306>();
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

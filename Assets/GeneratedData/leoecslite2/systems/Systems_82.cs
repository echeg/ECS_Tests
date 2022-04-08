using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System82 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component255>().Inc<Component452>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component24>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component24>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component490>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component490>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component141>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component141>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component306>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component306>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

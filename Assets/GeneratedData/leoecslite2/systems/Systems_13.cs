using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System13 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component176>().Inc<Component131>().Inc<Component338>().Inc<Component213>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component114>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component114>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component193>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component193>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component127>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component127>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component269>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component269>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

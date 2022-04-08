using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System98 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component260>().Inc<Component206>().Inc<Component107>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component242>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component242>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component240>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component240>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component74>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component74>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component12>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component12>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

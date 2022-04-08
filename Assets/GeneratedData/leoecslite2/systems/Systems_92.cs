using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System92 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component269>().Inc<Component194>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component329>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component329>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component244>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component244>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component419>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component419>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component468>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component468>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
